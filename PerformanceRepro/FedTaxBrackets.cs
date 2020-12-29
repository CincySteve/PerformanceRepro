using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    public class FedTaxBrackets
        {
        public Int32 Year { get; set; }
        public Int32 TaxFilingStatus { get; set; }
        public Decimal BracketStart { get; set; }
        public Decimal BracketEnd { get; set; }
        public Decimal BaseTax { get; set; }
        public Decimal MarginalRate { get; set; }

        public FedTaxBrackets() { }
        }
    }
