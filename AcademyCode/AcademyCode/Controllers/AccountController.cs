using AcademyCode.DAL.Model;
using AcademyCode.ModelsVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcademyCode.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<USERS> _userManager;
        private readonly SignInManager<USERS> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(UserManager<USERS> userManager, SignInManager<USERS> signInManager,ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegesterVM register)
        {
            if (ModelState.IsValid)
            {
                USERS _user = new USERS()
                {

                    Fname = register.Fname,
                    Lname = register.Lname,
                    Gender = register.Gender,
                    UserName = register.Email.Split('@')[0],
                    Email = register.Email,
                    EmailConfirmed = true,


                }; var result = await _userManager.CreateAsync(_user, register.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("LoginIn");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, err.Description);
                    }
                }
            }
            return View();
        }
        public IActionResult LoginIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginIn(Login log)
        {
            if (ModelState.IsValid)
            {
                //FindByEmailAsync
                var user = await _userManager.FindByEmailAsync(log.Email);
                if (user != null)
                {
                    var flag = await _userManager.CheckPasswordAsync(user, log.Password);
                    if (flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, log.Password, log.RememberMe, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "AcademyCode");
                        }

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "error");
                    }
                }
                    ModelState.AddModelError(string.Empty, "error");
                }
            

                return View(log);
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return View("LoginIn");
        }
            public async Task<IActionResult> ForgotBassword()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgortBassword(ForgotPassword forgotPassword)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(forgotPassword.Email);
                if (user != null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var ResetLink = Url.Action("ResetBassword", "Account", new { email = forgotPassword.Email, token = token }, Request.Scheme);
                    var em = new EmaiL()
                    {
                        To = user.Email,
                        Body = ResetLink,

                    };
                  
                    //https,port
                    _logger.Log(LogLevel.Warning, ResetLink);

                    return View("Confirmbassword");
                    
                }

                ModelState.AddModelError(string.Empty, "error");
            }
            return View(forgotPassword);
        }
        public IActionResult ResetBassword(string token,string email)
        {
            if(token == null)
            {
                ModelState.AddModelError( "", "invalid");
            }return View();
        }
        public async Task<IActionResult> ResetBassword(ResetBasword  resetpass)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(resetpass.Email);
                if(user != null)
                {
                    var result = await _userManager.ResetPasswordAsync(user, resetpass.Token, resetpass.Password); if (result.Succeeded)
                    {
                        return View();
                    }foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }return View(resetpass);
                }return View("SucConfirm");
            }return View(resetpass);
        }
    }
}
