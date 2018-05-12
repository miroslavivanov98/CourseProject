namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiroDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manafacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 20),
                        StreetName = c.String(nullable: false, maxLength: 20),
                        WorkTime = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 20),
                        PassHash = c.String(nullable: false, maxLength: 20),
                        IsAdmin = c.String(nullable: false, maxLength: 20),
                        IsBanned = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Caliber = c.Int(nullable: false),
                        Weight = c.String(nullable: false, maxLength: 20),
                        BarrelLength = c.String(nullable: false, maxLength: 20),
                        Price = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "IX_WeaponsNameUnique");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Weapons", "IX_WeaponsNameUnique");
            DropTable("dbo.Weapons");
            DropTable("dbo.Users");
            DropTable("dbo.Shops");
            DropTable("dbo.Manafacturers");
            DropTable("dbo.Categories");
        }
    }
}
