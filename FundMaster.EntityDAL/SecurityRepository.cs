using System.Linq;
using FundMaster.Entity;
using FundMaster.Utils;

namespace FundMaster.EntityDAL
{
    public class SecurityRepository : BaseRepository<Security>
    {
        public FundSummary GetFundSummaryBySecTypeId(int fundId, int secTypeId)
        {
                string secTypeName = Context.SecurityType.Where(f => f.Id == secTypeId).FirstOrDefault().Description;

                int? secCount = Context.Security
                .Join(Context.SecFund,
                    s => s.Id,
                    sf => sf.SecurityId,
                    (s, sf) => new { s, sf }).Where(sf => sf.sf.FundId == fundId && !sf.sf.IsDeleted).Where(s => s.s.SecurityTypeId == secTypeId && !s.s.IsDeleted)
                    .Count();

                decimal? totalSecWeight = Context.Security
                .Join(Context.SecFund,
                    s => s.Id,
                    sf => sf.SecurityId,
                    (s, sf) => new { s, sf }).Where(sf => sf.sf.FundId == fundId && !sf.sf.IsDeleted).Where(s => s.s.SecurityTypeId == secTypeId && !s.s.IsDeleted)
                    .Sum(sec => sec.s.SecWeight);

                decimal? totalMktValue = Context.Security
                .Join(Context.SecFund,
                    s => s.Id,
                    sf => sf.SecurityId,
                    (s, sf) => new { s, sf }).Where(sf => sf.sf.FundId == fundId && !sf.sf.IsDeleted).Where(s => s.s.SecurityTypeId == secTypeId && !s.s.IsDeleted)
                    .Sum(sec => sec.s.MktValue);

                return new FundSummary
                                {
                                    Name = secTypeName,
                                    TotalMktValue = totalMktValue,
                                    TotalStockWeight = totalSecWeight,
                                    TotalNumber = secCount
                                };
            }
        
        public IQueryable<Security> GetSecuritiesByFundId(int fundId)
        {
            return Context.SecFund.Where(f => f.FundId == fundId && !f.IsDeleted).Select(s => s.Security).Where(s => !s.IsDeleted);
        }

        public decimal? GetTotalMktValueByFundId(int fundId)
        {
            return Context.Security
                .Join(Context.SecFund,
                    s => s.Id,
                    sf => sf.SecurityId,
                    (s, sf) => new { s, sf }).Where(sf => sf.sf.FundId == fundId)
                .Sum(s => s.s.MktValue);
        }

        public IQueryable<object> GetSecurityTypes()
        {
            return Context.SecurityType.Select(st => st.Description);            
        }
        public SecurityType GetSecurityTypeByName(string name)
        {
            return Context.SecurityType.Where(st => st.Description == name).FirstOrDefault();
        }
        public SecurityType GetSecurityTypeById(int Id)
        {
            return Context.SecurityType.Where(st => st.Id == Id).FirstOrDefault();
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
        public IQueryable<SecurityType> GetAllSecurityTypesQuery()
        {
            return Context.SecurityType.AsQueryable();
        }
    }
}
