namespace TruYumWeb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TruYumWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TruYumWeb.Models.TruYumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TruYumWeb.Models.TruYumContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var category = new List<Category>
            {
            new Category{Id=1,Name="Main Course"},
            new Category{Id=2,Name="Staters"},
            new Category{Id=3,Name="Snack"}
            };
            category.ForEach(ns => context.Categories.AddOrUpdate(x => x.Id, ns));
            category.ForEach(ns => context.Categories.AddOrUpdate(x => x.Name, ns));
        }
    }
}
