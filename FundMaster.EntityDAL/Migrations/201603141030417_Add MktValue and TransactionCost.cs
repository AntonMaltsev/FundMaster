namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMktValueandTransactionCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Security", "MktValue", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Security", "TransactionCost", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Security", "TransactionCost");
            DropColumn("dbo.Security", "MktValue");
        }
    }
}
