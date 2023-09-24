namespace VidzyCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingReferenceDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) values (Action)");
            Sql("Insert into Genres (Name) values (Comedy)");
            Sql("Insert into Genres (Name) values (Sci-Fi)");
            Sql("Insert into Genres (Name) values (Horror)");
            Sql("Insert into Genres (Name) values (Animation)");
            Sql("Insert into Genres (Name) values ()");
        }
        
        public override void Down()
        {
        }
    }
}
