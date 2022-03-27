namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into GENRES(Id,GenreName) values (1, 'Comedy')");
            Sql("INSERT into GENRES(Id,GenreName) values (2, 'Action')");
            Sql("INSERT into GENRES(Id,GenreName) values (3, 'Family')");
            Sql("INSERT into GENRES(Id,GenreName) values (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
