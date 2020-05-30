namespace IP_NTier.DataAccess.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extenduserwithcreatedOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "CreatedOn");
        }
    }
}
