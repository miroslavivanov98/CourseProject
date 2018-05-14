namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miro : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weapons", "Caliber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Weapons", "Weight", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Weapons", "BarrelLength", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Weapons", "Price", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "Price", c => c.String(maxLength: 20));
            AlterColumn("dbo.Weapons", "BarrelLength", c => c.String(maxLength: 20));
            AlterColumn("dbo.Weapons", "Weight", c => c.String(maxLength: 20));
            AlterColumn("dbo.Weapons", "Caliber", c => c.String(maxLength: 20));
        }
    }
}
