using Day2MVC.Data;
using Day2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Day2MVC.Controllers
{
    public class ToDoController : Controller
    {
        TODoContext _dbContext ;
        public ToDoController(TODoContext todo)
        {
            this._dbContext = todo;
        }
        public IActionResult Index(int? id)
        {
             var _ToDosList = (from x in _dbContext.ToDos select x).ToList();
            if (id != null)
            {
                var MyToDO = (from x in _dbContext.ToDos where x.TODOID == id select x).FirstOrDefault();
                if (MyToDO != null)
                {
                    ViewBag.Name = MyToDO.Name;
                    ViewBag.Description = MyToDO.Description;
                   // var model = new ToDo { Name = MyToDO.Name, Description = MyToDO.Description };
                     return PartialView("_AddItem");
                }
                return RedirectToAction("Index");
            }
            return View(_ToDosList);
            
        }
        [HttpPost]
        public IActionResult Save(int? id, string name, string? description)
        {
          
            if (id != null)
            {
                var MyToDO = (from x in _dbContext.ToDos where x.TODOID == id select x).FirstOrDefault();
                MyToDO.Name = name;
                MyToDO.Description = description;
                _dbContext.ToDos.Update(MyToDO);
               
                return RedirectToAction("Index");
            } else {
                ToDo toDo = new ToDo();
                toDo.Name = name;
            toDo.Description = description;
            _dbContext.ToDos.Add(toDo);
           
        }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var MyToDO = (from x in _dbContext.ToDos where x.TODOID == id select x).FirstOrDefault();
            _dbContext.ToDos.Remove(MyToDO);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult Search(string Name)
        {
           
            var MyToDO = _dbContext.ToDos.Where(e => e.Name.Contains(Name)).ToList();
   
            return View("Index",MyToDO);

        }


    }
}
