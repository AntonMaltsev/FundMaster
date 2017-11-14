using System.Linq;
using FundMaster.Entity;

namespace FundMaster.EntityDAL
{
    public class FundRepository : BaseRepository<Fund>
    {
        public IQueryable<string> GetFundsNames()
        {
            return Context.Fund.Select(st => st.Name);
        }
        public Fund FindByName(string fundName)
        {
            return FirstOrDefault(b => b.Name.ToLower() == fundName.ToLower());
        }

        public IQueryable<Fund> GetNotRemovedFundQuery()
        {
            return Filter(s => !s.IsDeleted);
        }

        public IQueryable<Fund> GetAllFundsQuery()
        {
            return All();
        }

    }
}
