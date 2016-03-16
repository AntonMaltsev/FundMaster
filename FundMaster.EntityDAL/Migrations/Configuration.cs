namespace FundMaster.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityDAL;
    using Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<FundMasterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FundMaster.EntityDAL.FundMasterContext";
        }

        protected override void Seed(FundMasterContext context)
        {
            context.SecurityType.AddOrUpdate(st => st.Id, new SecurityType { Id = (int)SecurityType.SecurityTypeEnum.Equity, FeeRate = 0.5m, Tolerance = 20000, Description = Entity.Utils.Common.GetEnumDescription(SecurityType.SecurityTypeEnum.Equity) });
            context.SecurityType.AddOrUpdate(st => st.Id, new SecurityType { Id = (int)SecurityType.SecurityTypeEnum.Bond, FeeRate = 2m, Tolerance = 10000, Description = Entity.Utils.Common.GetEnumDescription(SecurityType.SecurityTypeEnum.Bond) });
            context.SecurityType.AddOrUpdate(st => st.Id, new SecurityType { Id = (int)SecurityType.SecurityTypeEnum.Future, Description = Entity.Utils.Common.GetEnumDescription(SecurityType.SecurityTypeEnum.Future) });
            context.SecurityType.AddOrUpdate(st => st.Id, new SecurityType { Id = (int)SecurityType.SecurityTypeEnum.Option, Description = Entity.Utils.Common.GetEnumDescription(SecurityType.SecurityTypeEnum.Option) });

            
            context.Security.AddOrUpdate(s => s.Id, new Security {SecurityTypeId = (int)SecurityType.SecurityTypeEnum.Equity, Name = "TestEquity", Price = 1, Qty = 1, IsDeleted = false });
            context.Security.AddOrUpdate(s => s.Id, new Security {SecurityTypeId = (int)SecurityType.SecurityTypeEnum.Bond, Name = "TestBond", Price = 1, Qty = 1, IsDeleted = false });
        }
    }
}