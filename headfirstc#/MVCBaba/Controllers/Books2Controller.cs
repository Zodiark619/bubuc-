using Microsoft.AspNetCore.Mvc;
using MVCBaba.Models;

namespace MVCBaba.Controllers
{
    public class Books2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Book2 book = new Book2()
            {
                Id = 1,
                Title = "Learnign sapdevepwgw",
                Genre = "Progemammafe sdkvjdfkjvd",
                Price = 45,
                PublishDate = new System.DateTime(2021, 04, 23),
                Authors=new List<string> { "Jasonfe ","ascdsadcs"}

            };
            return View(book);
        }
    }
}
