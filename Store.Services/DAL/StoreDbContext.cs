using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Store.Services;
using Store.Models;

namespace Store.Services.DAL
{
    public class StoreDbContext :DbContext
    {
        public StoreDbContext()
            :base("ConnectionContext")
        {

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<Company>  Company { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}