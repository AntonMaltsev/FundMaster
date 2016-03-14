using System.Linq;
using FundMaster.Entity;
using System.Data.Entity;

namespace FundMaster.EntityDAL
{
    public class SecurityRepository : BaseRepository<Security>
    {
        public IQueryable<Security> GetSecuritiesByFundId(int fundId)
        {
            return Context.SecFund.Where(f => f.FundId == fundId && !f.IsDeleted).Select(s => s.Security).Where(s => !s.IsDeleted);
        }
        public IQueryable<object> GetSecurityTypes()
        {
            return Context.SecurityType.Select(st => st.Description);            
        }
        public SecurityType GetSecurityTypeByName(string name)
        {
            return Context.SecurityType.Where(st => st.Description == name).FirstOrDefault();
        }

        public Security GetSecurityByName(string name)
        {            
            return Context.Security.Where(s => s.Name == name).FirstOrDefault();
        }

        public decimal? GetSecurityFeeRate(Security sec)
        {            
            return Context.SecurityType.FirstOrDefault(st => st.Id == sec.Id).FeeRate;
        }

        public IQueryable<Security> GetSecurityQuery()
        {
            return Filter(s => !s.IsDeleted);
        }

        public IQueryable<Security> GetAllSecuritiesQuery()
        {
            return All();
        }
    }
}
