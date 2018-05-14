namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeManufacturerColumnsToNotNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manafacturers", "Address", c => c.String(maxLength: 20));
            AlterColumn("dbo.Manafacturers", "Phone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manafacturers", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Manafacturers", "Address", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
