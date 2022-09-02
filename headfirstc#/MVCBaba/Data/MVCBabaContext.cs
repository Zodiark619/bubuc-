using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBaba.Models;

namespace MVCBaba.Data
{
    public class MVCBabaContext : DbContext
    {
        public MVCBabaContext (DbContextOptions<MVCBabaContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBaba.Models.Book> Book { get; set; } = default!;
    }
}
