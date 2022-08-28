using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using piiiza.Data;
using piiiza.Models;

namespace piiiza.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }


            BijaOdo susu = new BijaOdo();
            susu.BasePrice = PizzaPrice;
            susu.PizzaName=PizzaName;

            _context.BijaOdos.Add(susu);    
            _context.SaveChanges();

        }
    }
}
