namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.String());
            AddColumn("dbo.Movies", "NumberInStocks", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.String());
            AddColumn("dbo.Movies", "Genre_GenreName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Genre_GenreName");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "NumberInStocks");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
