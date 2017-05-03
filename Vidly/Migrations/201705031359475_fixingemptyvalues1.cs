namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingemptyvalues1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MbType='true'");
            Sql("UPDATE MembershipTypes SET MbType='false'");
            Sql("UPDATE MembershipTypes SET MbType='false'");
            Sql("UPDATE MembershipTypes SET MbType='true'");
        }
        
        public override void Down()
        {
        }
    }
}
