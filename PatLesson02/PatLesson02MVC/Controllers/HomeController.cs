using Microsoft.AspNetCore.Mvc;
using PatLesson02MVC.Models;
using System.Diagnostics;

namespace PatLesson02MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Name = "Product Name 1", Price = 500000, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
                new Models.Product { Id = 2, Name = "Product Name 2", Price = 700000, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
                new Models.Product { Id = 3, Name = "Product Name 3", Price = 550000, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
                new Models.Product { Id = 4, Name = "Product Name 4", Price = 550000, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" }
            };

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
