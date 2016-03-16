using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundMaster.Utils
{
    public class FundSummary
    {
        public string Name { get; set; }
        public decimal? TotalNumber { get; set; }
        public decimal? TotalStockWeight { get; set; }
        public decimal? TotalMktValue { get; set; }
    }
}
