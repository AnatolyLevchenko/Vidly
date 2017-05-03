namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillingBrithdays : DbMigration
    {
        public override void Up()
        {
            Sql($"UPDATE Customers  SET BrithDateTime='{DateTime.Now.Year-30}' WHERE Id=1");
            Sql($"UPDATE Customers  SET BrithDateTime='{DateTime.Now.Year-70}' WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
