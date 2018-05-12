namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CourseProject.DB.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProject.DataAccess.Class1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseProject.DataAccess.Class1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if(!context.Manafacturer.Any())
            {
                context.Manafacturer.AddOrUpdate(x => x.Id,
                    new Manafacturer() { Name = "Blaser" },
                    new Manafacturer() { Name = "Beneli" },
                    new Manafacturer() { Name = "Remington" },
                    new Manafacturer() { Name = "Ata" },
                    new Manafacturer() { Name = "Mauser" });
            }

            if (!context.Shop.Any())
            {
                context.Shop.AddOrUpdate(x => x.Id,
                    new Shop() { City = "Pleven",StreetName="bul Danail Popov" ,WorkTime="08:00-19:30"},
                    new Shop() { City = "Varna", StreetName ="bul Slivnica", WorkTime = "08:00-19:00" },
                    new Shop() { City = "Veliko Turnovo", StreetName ="bul Nikola Gabrovski", WorkTime = "08:00-19:30" },
                    new Shop() { City = "Plovdiv", StreetName ="bul Vasil Aprilov", WorkTime = "08:00-19:30" },
                    new Shop() { City = "Sofia", StreetName ="yl Ivan Aleksandur", WorkTime = "08:00-20:00" });
            }

            if (!context.Weapons.Any())
            {
                context.Weapons.AddOrUpdate(x => x.Id,
                    new Weapons() { ManafacturerId = 0,Name = "Cy", Caliber = "12", Weight = "2.0kg", Price = "1000" ,BarrelLength = "30s" },
                    new Weapons() { ManafacturerId = 1, Name = "R8 Luxus", Caliber = "12", Weight = "1.5kg", Price = "1400", BarrelLength = "29sm" },
                    new Weapons() { ManafacturerId = 2, Name = "Argo", Caliber = "12", Weight = "2.5kg", Price = "1800", BarrelLength = "39sm" },
                    new Weapons() { ManafacturerId = 3, Name = "700", Caliber = "12", Weight = "2.3kg", Price = "4000", BarrelLength = "33sm" },
                     new Weapons() { ManafacturerId = 4, Name = "M12 Extreme", Caliber = ".30.06", Weight = "3.1kg", Price = "9000", BarrelLength = "51sm" }
                     );
            }

            if (!context.Category.Any())
            {
                context.Category.AddOrUpdate(x => x.Id,
                    new Category() { Name = "Karabini" },
                    new Category() { Name = "Lovni avtomati" },
                    new Category() { Name = "Lovno pompi" },
                    new Category() { Name = "Klasichesi" },
                    new Category() { Name = "Kombinirani" });
            }


        }
    }
}
