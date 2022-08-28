using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using piiiza.Data;
using piiiza.Models;

namespace piiiza.Pages
{
    public class OOOrderModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<BijaOdo> mumu = new List<BijaOdo>();

        public OOOrderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            mumu = _context.BijaOdos.ToList();
        }
    }
}
