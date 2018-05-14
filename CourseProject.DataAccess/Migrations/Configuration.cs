namespace CourseProject.DataAccess.Migrations
{
    using CourseProject.DB.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
            if (!context.Manafacturer.Any())
            {
                context.Manafacturer.AddOrUpdate(x => x.Id,
                    new Manafacturer() { Id = 1, Name = "Blaser",Address="Pleven",Phone="0886134537" },
                    new Manafacturer() { Id = 2, Name = "Beneli", Address = "Varna", Phone = "0886312357" },
                    new Manafacturer() { Id = 3, Name = "Remington", Address = "Plovdiv", Phone = "0886974742" },
                    new Manafacturer() { Id = 4, Name = "Ata", Address = "Veliko Turnovo", Phone = "0888765537" },
                    new Manafacturer() { Id = 5, Name = "Mauser", Address = "Sofia", Phone = "0883747174" });
            }
            
            if (!context.Shop.Any())
            {
                context.Shop.AddOrUpdate(x => x.Id,
                    new Shop() { Id = 1,City = "Pleven", StreetName = "bul Danail Popov", WorkTime = "08:00-19:30" },
                    new Shop() { Id = 2,City = "Varna", StreetName = "bul Slivnica", WorkTime = "08:00-19:00" },
                    new Shop() { Id = 3,City = "Veliko Turnovo", StreetName = "bul Nikola Gabrovski", WorkTime = "08:00-19:30" },
                    new Shop() { Id = 4,City = "Plovdiv", StreetName = "bul Vasil Aprilov", WorkTime = "08:00-19:30" },
                    new Shop() { Id = 5,City = "Sofia", StreetName = "yl Ivan Aleksandur", WorkTime = "08:00-20:00" });
            }
            
            if (!context.Weapons.Any())
            {
                context.Weapons.AddOrUpdate(x => x.Id,
                    new Weapon() { Id = 1, Name = "Cy", Caliber = "12", Weight = "2.0kg", BarrelLength = "30sm", Price = "1000" },
                    new Weapon() { Id = 2, Name = "R8 Luxus", Caliber = "12", Weight = "1.5kg", BarrelLength = "30sm", Price = "1400" },
                    new Weapon() { Id = 3, Name = "Argo", Caliber = "12", Weight = "2.5kg", BarrelLength = "30sm", Price = "1800"},
                    new Weapon() { Id = 4, Name = "7001", Caliber = "12", Weight = "2.3kg", BarrelLength = "30sm", Price = "4000" },
                     new Weapon() { Id = 5, Name = "M12 Extreme", Caliber = "30.06", Weight = "3.1kg", BarrelLength = "30sm", Price = "9000"}
                     );

            }
           
            if (!context.Category.Any())
            {
                context.Category.AddOrUpdate(x => x.Id,
                    new Category() { Id = 1,Name = "Karabini" },
                    new Category() {Id = 2, Name = "Lovni avtomati" },
                    new Category() {Id = 3, Name = "Lovno pompi" },
                    new Category() {Id = 4, Name = "Klasichesi" },
                    new Category() { Id = 5,Name = "Kombinirani" });
            }
           
        }
    }
}
