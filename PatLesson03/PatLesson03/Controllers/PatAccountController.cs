using Microsoft.AspNetCore.Mvc;
using PatLesson03.Models;
using System.Linq;
namespace PatLesson03.Controllers
{
    public class PatAccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> account = new List<Account> {
                new Account
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "blabla@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a1.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1995, 5, 15)
                },
                new Account
                {
                    Id = 2,
                    Name = "Jack",
                    Email = "blabla2@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a2.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1997, 5, 15)
                },
                new Account
                {
                    Id = 3,
                    Name = "Peter",
                    Email = "blabla3@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a3.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1995, 5, 25)
                },
            };
            ViewBag.Accounts = account;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account> {
                new Account
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "blabla@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a1.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1995, 5, 15)
                },
                new Account
                {
                    Id = 2,
                    Name = "Jack",
                    Email = "blabla2@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a2.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1997, 5, 15)
                },
                new Account
                {
                    Id = 3,
                    Name = "Peter",
                    Email = "blabla3@gmail.com",
                    Phone = "123-456-7890",
                    Avatar = "/images/Avatar/a3.jpg",
                    Address = "Ha Noi",
                    Gender = 1,
                    DateOfBirth = new DateTime(1995, 5, 25)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.account = account;
            return View();


        }
    }
}
