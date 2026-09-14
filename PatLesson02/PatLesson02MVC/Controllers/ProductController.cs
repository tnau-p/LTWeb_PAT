using Microsoft.AspNetCore.Mvc;
using PatLesson02MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatLesson02MVC.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 500000m, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
            new Product { Id = 2, Name = "Product 2", Price = 700000m, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
            new Product { Id = 3, Name = "Product 3", Price = 550000m, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
            new Product { Id = 4, Name = "Product 4", Price = 550000m, CreatedAt = new DateTime(2020,12,25), ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.EzWiXUC-NRygKbxYFYLFSgHaHa?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" }
        };

        public IActionResult Index()
        {
            return View(_products);
        }

        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
