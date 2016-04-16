using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundMaster.EntityDAL;
using FundMaster.ViewModel;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace FundMaster.Test
{

    [TestClass]    
    public class FundMasterUT
    {
        private FundMasterContext fm_Context;
        public FundMasterUT()
            {            
                fm_Context = new FundMasterContext();
            }

        [TestMethod]
        public void EquityFeeRateCheck()
        {           
            var sec = fm_Context.Security.Where(s => s.Name == "TestEquity").FirstOrDefault();
            var secType = fm_Context.SecurityType.FirstOrDefault(st => st.Id == sec.SecurityTypeId);

            if (sec != null)
                Assert.IsTrue(sec.Qty * secType.FeeRate == 0.5m ? true : false);
            else
                Assert.IsTrue(false);
        }


        [TestMethod]
        public void BondFeeRateCheck()
        {
            var fr = new SecurityRepository();
            var sec = fr.GetSecurityByName("TestBond");

            Assert.IsTrue((sec != null)? sec.Qty * fr.GetSecurityFeeRate(sec) == 2m : false);
        }
        
    }
}
