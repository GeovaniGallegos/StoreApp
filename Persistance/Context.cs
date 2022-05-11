using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class Context :DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Stock>? Stock { get; set; }
        public DbSet<Store>? Stores { get; set; }
    }
}
