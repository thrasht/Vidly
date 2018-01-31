namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDayOfBirth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirthday", c => c.DateTime(nullable: false));
        }
    }
}
