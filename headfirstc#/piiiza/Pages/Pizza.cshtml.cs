using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using piiiza.Models;

namespace piiiza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<Bija> fakeBija = new List<Bija>()
        {
            new Bija()
            {
                ImageTitle="Margerita",
                PizzaName="Margegegege",
                BasePrice=32,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=34 
            },
            new Bija()
            {
                ImageTitle="Bolognese",
                PizzaName="bolobolo",
                BasePrice=42,
                Beef=true,
                Ham=true,
                FinalPrice=44
            },
            new Bija()
            {
                ImageTitle="Mushroom",
                PizzaName="Margegemumugege",
                BasePrice=114,
                Pineapple=true,
                Mushroom=true,
                FinalPrice=213
            },
        };
        public void OnGet()
        {
        }
    }
}
