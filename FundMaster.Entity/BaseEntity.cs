using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundMaster.Entity
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "CreatedUTC should have value")]
        public DateTime CreatedUTC { get; set; }

        public DateTime? UpdatedUTC { get; set; }

        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            CreatedUTC = DateTime.UtcNow;
        }

        [NotMapped]
        public DateTime UpdatedCreated
        {
            get
            {
                return UpdatedUTC.HasValue ? UpdatedUTC.Value : CreatedUTC;
            }
        }
    }
}
