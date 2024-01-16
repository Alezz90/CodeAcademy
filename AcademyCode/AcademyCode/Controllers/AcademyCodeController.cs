using AcademyCode.BLL.Interface;
using AcademyCode.BLL.Repo;
using AcademyCode.DAL.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AcademyCode.Controllers
{
    public class AcademyCodeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
       

        public AcademyCodeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string name)
        {
            IEnumerable<Employee> Emp ;
            
            if(name != null)
            {
                Emp = _unitOfWork.EployeeRepo.Search(name);
            }
             Emp = _unitOfWork.EployeeRepo.GetAll();
            return View(Emp);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Emp = _unitOfWork.EployeeRepo.Get(id.Value);
            return View(Emp);

        }
        public IActionResult Create()
        {
           // var departments = _unitOfWork.DepartmentRepo.GetAll();
            ViewBag.Departments = _unitOfWork.DepartmentRepo.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee Emp)
        {
            
           /* var departments = _unitOfWork.DepartmentRepo.GetAll();
            ViewBag.DepartmentID = new SelectList(departments, "Id", "Name");*/

            if (ModelState.IsValid)
            {
                _unitOfWork.EployeeRepo.Create(Emp);

               

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
            var Emp = _unitOfWork.EployeeRepo.Get(id.Value);
            return View(Emp);

        }
        [HttpPost]
        public IActionResult Update(Employee Emp)
        {

            _unitOfWork.EployeeRepo.Update(Emp);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(Employee Emp)
        {

            _unitOfWork.EployeeRepo.Delete(Emp);
            return RedirectToAction("Index");

        }

    }
}