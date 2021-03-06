﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FundMaster.Entity
{
    public class Security : BaseEntity 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public override int Id { get; set; }
        public int SecurityTypeId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Qty { get; set; }

        public decimal? MktValue { get; set; }

        public decimal? TransactionCost { get; set; }
        public decimal? SecWeight { get; set; }

        public virtual SecurityType SecurityType { get; set; }
    }
}