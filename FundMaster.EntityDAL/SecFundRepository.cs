using System.Linq;
using FundMaster.Entity;
using System.Data.Entity;

namespace FundMaster.EntityDAL
{
    public class SecFundRepository : BaseRepository<SecFund>
    {
        public Security IfSecurityInFund(int fundId, int secId)
        {
            return Context.SecFund.Where(f => f.FundId == fundId && f.SecurityId == secId).Select(s => s.Security).FirstOrDefault();                
        }
        public SecFund SecFundByIds(int fundId)
        {
            return Context.SecFund.Where(f => f.FundId == fundId).FirstOrDefault();
        }

        public SecFund SecFundByIds(int fundId, int secId)
        {
            return Context.SecFund.Where(f => f.FundId == fundId && f.SecurityId == secId).FirstOrDefault();
        }

        public IQueryable<SecFund> GetAllSecFundQuery()
        {
            return All();
        }
    }
}
