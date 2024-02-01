using AcademyCode.BLL.Interface;
using AcademyCode.BLL.Repo;
using AcademyCode.DAL.Model;
using AcademyCode.Helper;
using AcademyCode.ModelsVM;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace AcademyCode.Controllers
{
    public class AcademyCodeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AcademyCodeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
            ViewBag.Departments = _unitOfWork.DepartmentRepo.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM Emp)
        {

            /* var departments = _unitOfWork.DepartmentRepo.GetAll();
             ViewBag.DepartmentID = new SelectList(departments, "Id", "Name");*/

            //  if (ModelState.IsValid)
            //  {
            Emp.ImagePath = DucomentConfi.DocumentUplod(Emp.formFile,"Images");

                var map = _mapper.Map<EmployeeVM, Employee>(Emp);
                _unitOfWork.EployeeRepo.Create(map);
                return RedirectToAction("Index");
          //  }
          //  return View(Emp);

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