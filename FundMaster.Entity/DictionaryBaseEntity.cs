using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundMaster.Entity
{
    public abstract class DictionaryBaseEntity : BaseEntity
    {
        [MaxLength(400)]
        public string Description { get; set; }

    }
}
