namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fund",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedUTC = c.DateTime(nullable: false),
                        UpdatedUTC = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecFund",
                c => new
                    {
                        SecurityId = c.Int(nullable: false),
                        FundId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        CreatedUTC = c.DateTime(nullable: false),
                        UpdatedUTC = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.SecurityId, t.FundId })
                .ForeignKey("dbo.SecurityType", t => t.FundId)
                .ForeignKey("dbo.SecurityType", t => t.SecurityId)
                .Index(t => t.SecurityId)
                .Index(t => t.FundId);
            
            CreateTable(
                "dbo.SecurityType",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FeeRate = c.Decimal(precision: 18, scale: 2),
                        Description = c.String(maxLength: 400),
                        CreatedUTC = c.DateTime(nullable: false),
                        UpdatedUTC = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Security",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SecurityTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Qty = c.Int(nullable: false),
                        CreatedUTC = c.DateTime(nullable: false),
                        UpdatedUTC = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SecurityType", t => t.SecurityTypeId)
                .Index(t => t.SecurityTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecFund", "SecurityId", "dbo.SecurityType");
            DropForeignKey("dbo.SecFund", "FundId", "dbo.SecurityType");
            DropForeignKey("dbo.Security", "SecurityTypeId", "dbo.SecurityType");
            DropIndex("dbo.Security", new[] { "SecurityTypeId" });
            DropIndex("dbo.SecFund", new[] { "FundId" });
            DropIndex("dbo.SecFund", new[] { "SecurityId" });
            DropTable("dbo.Security");
            DropTable("dbo.SecurityType");
            DropTable("dbo.SecFund");
            DropTable("dbo.Fund");
        }
    }
}
