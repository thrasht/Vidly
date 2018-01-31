namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDayOfBirthdayColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirthday");
        }
    }
}
