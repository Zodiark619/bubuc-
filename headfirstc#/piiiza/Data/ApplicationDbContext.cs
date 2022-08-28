using Microsoft.EntityFrameworkCore;
using piiiza.Models;

namespace piiiza.Data
{
    public class ApplicationDbContext:DbContext
    {
        //install ms.entityframeworkcore,ms.efcore.sqlserver,ms.efcore.tools
        public DbSet<BijaOdo> BijaOdos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

    }
}
