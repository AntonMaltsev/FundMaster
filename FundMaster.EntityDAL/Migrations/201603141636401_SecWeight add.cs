namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecWeightadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Security", "SecWeight", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Security", "SecWeight");
        }
    }
}
