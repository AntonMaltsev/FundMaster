namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionCostupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Security", "TransactionCost", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Security", "TransactionCost", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
