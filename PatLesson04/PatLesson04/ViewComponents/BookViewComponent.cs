using Microsoft.AspNetCore.Mvc;
using PatLesson04.Models;

namespace PatLesson04.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
