using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundMaster.EntityDAL;
using FundMaster.ViewModel;
using System.Data.Entity.SqlServer;

namespace FundMaster.Test
{
    
        [DeploymentItem("EntityFramework.SqlServer.dll")]
        internal static class MissingDllHack
        {
            private static SqlProviderServices instance = SqlProviderServices.Instance;
        }
    
    [TestClass]    
    public class FundMasterUT
    {        
        [TestMethod]
        public void EquityFeeRateCheck()
        {
            var vm = new MaintenanceFormViewModel();            
            var sec = vm.CurrentSecurityRep.GetSecurityByName("TestEquity");
            
            Assert.IsTrue((sec != null) ? vm.CurrentSecurity.Qty * vm.CurrentSecurityRep.GetSecurityFeeRate(sec) == 0.005m : false);
        }

        [TestMethod]
        public void BondFeeRateCheck()
        {
            var fr = new SecurityRepository();
            var sec = fr.GetSecurityByName("TestBond");

            Assert.IsTrue((sec != null)? sec.Qty * fr.GetSecurityFeeRate(sec) == 0.02m : false);
        }
        
    }
}
