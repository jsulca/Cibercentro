using Microsoft.AspNetCore.Mvc;

namespace Cibercentro.WebApp.Controllers
{
    public class HomeController : Controller
    {
                public IActionResult Index()
        {
            return View();
        }
    }
}