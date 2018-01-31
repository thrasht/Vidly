namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDataInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Description = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Description = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Description = '3 Monthly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Description = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
