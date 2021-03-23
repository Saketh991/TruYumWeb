using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
//using System.Data.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TruYumWeb.Models
{
    public class TruYumContext : DbContext
    {
        public TruYumContext() : base("name=TruYumContext")
        {

        }

        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}