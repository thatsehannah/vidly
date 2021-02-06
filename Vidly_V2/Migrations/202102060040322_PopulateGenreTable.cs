namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,\'Comedy\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,\'Drama\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,\'Thriller\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,\'Horror\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6,\'Action\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7,\'Romance\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8,\'Family\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9,\'Kids\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10,\'Sci-Fi\')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11,\'Documentary\')");
        }
        
        public override void Down()
        {
        }
    }
}
