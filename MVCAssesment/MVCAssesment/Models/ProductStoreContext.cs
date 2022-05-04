using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAssesment.Models
{
    public class ProductStoreContext : DbContext
    {
        public ProductStoreContext() : base("Name=PSContext")
        {
            
        }
        public DbSet<Category> category { get; set; }
        public DbSet<ProductUnit> punit { get; set; }
        public DbSet<Product> product { get; set; }
    }
}