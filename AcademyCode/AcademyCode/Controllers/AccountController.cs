using AcademyCode.DAL.Model;
using AcademyCode.ModelsVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcademyCode.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<USERS> _userManager;
        private readonly SignInManager<USERS> _signInManager;

        public AccountController(UserManager<USERS> userManager,SignInManager<USERS> signInManager)
        {
           _userManager = userManager;
           _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegesterVM register)
        {
            if(ModelState.IsValid)
            {
                USERS _user = new USERS()
                {
                    Fname = register.Fname,
                    Lname = register.Lname,
                    Gender = register.Gender,
                    UserName = register.UserName,
                    Email = register.Email,
                    
                  
                }; var result = await _userManager.CreateAsync(_user, register.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
        }
            return View();
        }
    }
}
