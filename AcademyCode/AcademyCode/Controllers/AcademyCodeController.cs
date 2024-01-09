using AcademyCode.BLL.Interface;
using CodeAcademy.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace AcademyCode.Controllers
{
    public class AcademyCodeController : Controller
    {
        private readonly IEmployee _Employee;
       

        public AcademyCodeController(IEmployee EmpRepo)
        {

            _Employee = EmpRepo;
        }

        public IActionResult Index()
        {
            var Emp = _Employee.GetAll();
            return View(Emp);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Emp = _Employee.Get(id.Value);
            return View(Emp);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee Emp)
        {
            if (ModelState.IsValid)
            {
                _Employee.Create(Emp);

                return RedirectToAction("Index");
            }
            return View();

        }
       
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Emp = _Employee.Get(id.Value);
            return View(Emp);

        }
        [HttpPost]
        public IActionResult Update(Employee Emp)
        {

            _Employee.Update(Emp);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(Employee Emp)
        {

            _Employee.Delete(Emp);
            return RedirectToAction("Index");

        }

    }
}