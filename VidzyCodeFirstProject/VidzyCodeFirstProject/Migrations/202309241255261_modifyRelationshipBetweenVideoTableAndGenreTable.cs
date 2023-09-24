namespace VidzyCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyRelationshipBetweenVideoTableAndGenreTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Videos", "Genre_Id", c => c.Byte());
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropColumn("dbo.Videos", "Genre_Id");
            DropColumn("dbo.Videos", "GenreId");
        }
    }
}
