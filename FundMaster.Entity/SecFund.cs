using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FundMaster.Entity
{
    public class SecFund : BaseEntity
    {
        [Key]
        [Column(Order = 1)]
        public int SecurityId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int FundId { get; set; }

        public virtual SecurityType Security { get; set; }
        public virtual SecurityType Fund { get; set; }
    }
}
