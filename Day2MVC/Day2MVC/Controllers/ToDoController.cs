using Day2MVC.Data;
using Day2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Day2MVC.Controllers
{
    public class ToDoController : Controller
    {
        TODoContext _dbContext ;
        public ToDoController(TODoContext todo)
        {
            this._dbContext = todo;
        }
      /*  public IActionResult Index(int? id)
        {
            var _ToDosList = (from x in _dbContext.ToDos select x).ToList();

            return View( _ToDosList);
        }*/
              public IActionResult Index(int? id)
              {
            var _ToDosList = (from x in _dbContext.ToDos select x).ToList();

                      return View(_ToDosList);
              }

            [HttpPost]
        public IActionResult Save(int? id, string name, string? description)
        {
            if (ModelState.IsValid)
            {
                ToDo toDo = new ToDo();
                toDo.Name = name;
                toDo.Description = description;
                _dbContext.ToDos.Update(toDo);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();

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
        
        public IActionResult Update(int id )
        {
                var MyToDO = _dbContext.ToDos.Find(id);
           
                return PartialView("_Update",MyToDO);
        }

         /*  
        public IActionResult Update(int? id, string name, string? description)
        {
                var MyToDO = (from x in _dbContext.ToDos where x.TODOID == id select x).FirstOrDefault();
                MyToDO.Name = name;
                MyToDO.Description = description;
                _dbContext.ToDos.Update(MyToDO);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");

        }


        */
    }
}
