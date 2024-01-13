using AcademyCode.BLL.Interface;
using AcademyCode.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace AcademyCode.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _Department;
        public DepartmentController(IDepartment department)
        {
            _Department = department;
        }
        public IActionResult Index()
        {
            var Dep = _Department.GetAll();
            return View(Dep);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Dep = _Department.Get(id.Value);
            return View(Dep);

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Department Dep)
        {
            if (ModelState.IsValid)
            {
                _Department.Create(Dep);
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
            var Dep = _Department.Get(id.Value);
            return View(Dep);

        }
        [HttpPost]
        public IActionResult Update(Department Dep)
        {
            if (ModelState.IsValid)
            {

                _Department.Update(Dep);

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(Department Dep)
        {

            _Department.Delete(Dep);
            return RedirectToAction("Index");

        }
    }
}
