namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'Action')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'Horror')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'Family')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
