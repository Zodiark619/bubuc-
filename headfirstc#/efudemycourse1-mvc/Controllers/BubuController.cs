using efudemycourse1_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace efudemycourse1_mvc.Controllers
{
    public class BubuController : Controller
    {
        private static List<Cow> cows=new List<Cow>();
        public IActionResult Meong()
        {
            
            return View(cows);
        }

        public IActionResult Create()
        {
            Cow meong = new Cow();

            return View(meong);
        }

        public IActionResult CreateCow(Cow meong)
        {
            cows.Add(meong);
            
            return RedirectToAction(nameof(Meong));
        }
    }
}
