using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FundMaster.Entity
{
    public class SecurityType : DictionaryBaseEntity
    {
        public SecurityType()
        {
            Security = new List<Security>();
        }
        public decimal? FeeRate { get; set; }

        public enum SecurityTypeEnum
        {
            [Description("Equity")]
            Equity = 0,
            [Description("Bond")]
            Bond = 1,
            [Description("Option")]
            Option = 2,
            [Description("Future")]
            Future = 3
        }
        public virtual List<Security> Security { get; private set; }
    }
}
