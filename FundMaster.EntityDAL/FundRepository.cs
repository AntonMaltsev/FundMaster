using System.Linq;
using FundMaster.Entity;

namespace FundMaster.EntityDAL
{
    public class FundRepository : BaseRepository<Fund>
    {
        public Fund FindByName(string fundName)
        {
            return FirstOrDefault(b => b.Name.ToLower() == fundName.ToLower());
        }

        public IQueryable<Fund> GetFundQuery()
        {
            return Filter(s => !s.IsDeleted);
        }

        public IQueryable<Fund> GetAllFundsQuery()
        {
            return All();
        }

    }
}
