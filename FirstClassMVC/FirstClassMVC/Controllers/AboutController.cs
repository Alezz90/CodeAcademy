using Microsoft.AspNetCore.Mvc;

namespace FirstClassMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
