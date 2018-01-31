namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(name) VALUES('Comedia')");
            Sql("INSERT INTO Genres(name) VALUES('Terror')");
            Sql("INSERT INTO Genres(name) VALUES('Drama')");
            Sql("INSERT INTO Genres(name) VALUES('Romántica')");
            Sql("INSERT INTO Genres(name) VALUES('XXX')");
        }
        
        public override void Down()
        {
        }
    }
}
