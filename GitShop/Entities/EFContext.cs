using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitShop.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Connection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Prodcuts { get; set; }
    }
}
