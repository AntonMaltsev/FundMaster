using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FundMaster.Entity
{
    public class SecFund : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public int SecurityId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int FundId { get; set; }

        public virtual Security Security { get; set; }
        public virtual Fund Fund { get; set; }
    }
}
