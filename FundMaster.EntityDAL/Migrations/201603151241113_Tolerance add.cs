namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Toleranceadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SecurityType", "Tolerance", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SecurityType", "Tolerance");
        }
    }
}
