using Microsoft.AspNetCore.Mvc;

namespace PatLesson09.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
