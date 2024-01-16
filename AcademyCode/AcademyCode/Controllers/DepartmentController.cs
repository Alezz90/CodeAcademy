using AcademyCode.BLL.Interface;
using AcademyCode.DAL.Model;
using AcademyCode.ModelsVM;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace AcademyCode.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var Dep = _unitOfWork.DepartmentRepo.GetAll();
            return View(Dep);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Dep = _unitOfWork.DepartmentRepo.Get(id.Value);
            return View(Dep);

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM Dep)
        {
            if (ModelState.IsValid)
            {
                var map = _mapper.Map<DepartmentVM,Department>(Dep);
                _unitOfWork.DepartmentRepo.Create(map);
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
            var Dep = _unitOfWork.DepartmentRepo.Get(id.Value);
            return View(Dep);

        }
        [HttpPost]
        public IActionResult Update(Department Dep)
        {
            if (ModelState.IsValid)
            {

                _unitOfWork.DepartmentRepo.Update(Dep);

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(Department Dep)
        {

            _unitOfWork.DepartmentRepo.Delete(Dep);
            return RedirectToAction("Index");

        }
    }
}
