using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FundMaster.Entity;


namespace FundMaster.EntityDAL
{
    public class FundMasterContext : DbContext
    {
        public DbSet<Security> Security { get; set; }
        public DbSet<Fund> Fund { get; set; }
        public DbSet<SecFund> SecFund { get; set; }

        #region Dictionaries
        public DbSet<SecurityType> SecurityType { get; set; }
        #endregion

        public FundMasterContext() : base("FundMasterLocal")
        {
           Database.SetInitializer<FundMasterContext>(null);
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }        
    }
}
