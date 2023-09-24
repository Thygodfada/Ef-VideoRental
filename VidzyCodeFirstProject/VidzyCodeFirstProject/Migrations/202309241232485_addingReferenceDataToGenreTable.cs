namespace VidzyCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingReferenceDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Genres (id, Name) values(1, 'Action')");
            Sql("Insert into dbo.Genres (id, Name) values (2, 'Comedy')");
            Sql("Insert into dbo.Genres (id, Name) values (3, 'Sci-Fi')");
            Sql("Insert into dbo.Genres (id, Name) values (4, 'Horror')");
            Sql("Insert into dbo.Genres (id, Name) values (5, 'Animation')");
            Sql("Insert into dbo.Genres (id, Name) values (6, 'Fantasy')");
        }
        
        public override void Down()
        {
            Sql("Delete from dbo.Genres");
        }
    }
}
