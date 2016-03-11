using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FundMaster.Entity
{
    public class Security : BaseEntity
    {
        public int SecurityTypeId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Qty { get; set; }

        public virtual SecurityType SecurityType { get; set; }
    }
}
