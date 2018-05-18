namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "StreetName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Weapons", "Caliber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "Caliber", c => c.String(nullable: false));
            AlterColumn("dbo.Shops", "StreetName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
