using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inl2
{
    public class KundContext : DbContext
    {
        public DbSet<Produkt> Produkts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Kund> Kunder { get; set; } 
        public DbSet<Kategori> Kategorier { get; set; }
         
    }
}
