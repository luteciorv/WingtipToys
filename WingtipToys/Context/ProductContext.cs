using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WingtipToys.Models;

namespace WingtipToys.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {

        }

        // Entidades/Tabelas
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}