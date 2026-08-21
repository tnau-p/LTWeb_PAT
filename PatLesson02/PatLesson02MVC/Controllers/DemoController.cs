using Microsoft.AspNetCore.Mvc;

namespace PatLesson02MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
