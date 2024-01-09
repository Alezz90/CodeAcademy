using AcademyCode.BLL.Interface;
using CodeAcademy.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace N_Tier_architectur.Controllers
{
    public class CodeAcademyController : Controller
    {


        private readonly IEmployee _Employee;

        //IDepartmentReposatory depo = new DepartmentRepository();
        public CodeAcademyController(IEmployee EmployeeRepo)
        {

            _Employee = EmployeeRepo;
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

            _Employee.Create(Emp);

            return RedirectToAction("Index");
        }

    }
}