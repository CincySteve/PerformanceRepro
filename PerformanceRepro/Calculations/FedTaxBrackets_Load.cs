using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    public static class FedTaxBrackets_Load
        {
        public static void Load()
            {
            FedTaxBrackets FedTaxBrackets;
            X_.FedTaxBracketsList = new List<FedTaxBrackets>();

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 8700m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 8700m;
            FedTaxBrackets.BracketEnd = 35350m;
            FedTaxBrackets.BaseTax = 870m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 35350m;
            FedTaxBrackets.BracketEnd = 85650m;
            FedTaxBrackets.BaseTax = 4867.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 85650m;
            FedTaxBrackets.BracketEnd = 178650m;
            FedTaxBrackets.BaseTax = 17442.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 178650m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 43482.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 112683.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 17400m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 17400m;
            FedTaxBrackets.BracketEnd = 70700m;
            FedTaxBrackets.BaseTax = 1740m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 70700m;
            FedTaxBrackets.BracketEnd = 142700m;
            FedTaxBrackets.BaseTax = 9735m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 142700m;
            FedTaxBrackets.BracketEnd = 217450m;
            FedTaxBrackets.BaseTax = 27735m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 217450m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 48665m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 105062m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 12400m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 12400m;
            FedTaxBrackets.BracketEnd = 47350m;
            FedTaxBrackets.BaseTax = 1240m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 47350m;
            FedTaxBrackets.BracketEnd = 122300m;
            FedTaxBrackets.BaseTax = 6483.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 122300m;
            FedTaxBrackets.BracketEnd = 198050m;
            FedTaxBrackets.BaseTax = 25221m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 198050m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 46431m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2011;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 109230m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 8700m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 8700m;
            FedTaxBrackets.BracketEnd = 35350m;
            FedTaxBrackets.BaseTax = 870m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 35350m;
            FedTaxBrackets.BracketEnd = 85650m;
            FedTaxBrackets.BaseTax = 4867.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 85650m;
            FedTaxBrackets.BracketEnd = 178650m;
            FedTaxBrackets.BaseTax = 17442.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 178650m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 43482.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 112683.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 17400m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 17400m;
            FedTaxBrackets.BracketEnd = 70700m;
            FedTaxBrackets.BaseTax = 1740m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 70700m;
            FedTaxBrackets.BracketEnd = 142700m;
            FedTaxBrackets.BaseTax = 9735m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 142700m;
            FedTaxBrackets.BracketEnd = 217450m;
            FedTaxBrackets.BaseTax = 27735m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 217450m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 48665m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 105062m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 12400m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 12400m;
            FedTaxBrackets.BracketEnd = 47350m;
            FedTaxBrackets.BaseTax = 1240m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 47350m;
            FedTaxBrackets.BracketEnd = 122300m;
            FedTaxBrackets.BaseTax = 6482.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 122300m;
            FedTaxBrackets.BracketEnd = 198050m;
            FedTaxBrackets.BaseTax = 25220m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 198050m;
            FedTaxBrackets.BracketEnd = 388350m;
            FedTaxBrackets.BaseTax = 46430m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2012;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 388350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 109229m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 8925m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 8925m;
            FedTaxBrackets.BracketEnd = 36250m;
            FedTaxBrackets.BaseTax = 892.5m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 36250m;
            FedTaxBrackets.BracketEnd = 87850m;
            FedTaxBrackets.BaseTax = 4991.25m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 87850m;
            FedTaxBrackets.BracketEnd = 183250m;
            FedTaxBrackets.BaseTax = 17891.25m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 183250m;
            FedTaxBrackets.BracketEnd = 398350m;
            FedTaxBrackets.BaseTax = 44603.25m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 398350m;
            FedTaxBrackets.BracketEnd = 400000m;
            FedTaxBrackets.BaseTax = 115586.25m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 400000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 116163.75m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 17850m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 17850m;
            FedTaxBrackets.BracketEnd = 72500m;
            FedTaxBrackets.BaseTax = 1785m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 72500m;
            FedTaxBrackets.BracketEnd = 146400m;
            FedTaxBrackets.BaseTax = 9982.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 146400m;
            FedTaxBrackets.BracketEnd = 223050m;
            FedTaxBrackets.BaseTax = 28457.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 223050m;
            FedTaxBrackets.BracketEnd = 398350m;
            FedTaxBrackets.BaseTax = 49919.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 398350m;
            FedTaxBrackets.BracketEnd = 450000m;
            FedTaxBrackets.BaseTax = 107768.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 450000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 125846m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 12750m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 12750m;
            FedTaxBrackets.BracketEnd = 48600m;
            FedTaxBrackets.BaseTax = 1275m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 48600m;
            FedTaxBrackets.BracketEnd = 125450m;
            FedTaxBrackets.BaseTax = 6652.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 125450m;
            FedTaxBrackets.BracketEnd = 203150m;
            FedTaxBrackets.BaseTax = 25865m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 203150m;
            FedTaxBrackets.BracketEnd = 398350m;
            FedTaxBrackets.BaseTax = 47621m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 398350m;
            FedTaxBrackets.BracketEnd = 425000m;
            FedTaxBrackets.BaseTax = 112037m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2013;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 425000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 121364.5m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9075m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9075m;
            FedTaxBrackets.BracketEnd = 36900m;
            FedTaxBrackets.BaseTax = 907.5m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 36900m;
            FedTaxBrackets.BracketEnd = 89350m;
            FedTaxBrackets.BaseTax = 5081.25m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 89350m;
            FedTaxBrackets.BracketEnd = 186350m;
            FedTaxBrackets.BaseTax = 18193.75m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 186350m;
            FedTaxBrackets.BracketEnd = 405100m;
            FedTaxBrackets.BaseTax = 45353.75m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 405100m;
            FedTaxBrackets.BracketEnd = 406750m;
            FedTaxBrackets.BaseTax = 117541.25m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 406750m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 118118.75m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 18150m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 18150m;
            FedTaxBrackets.BracketEnd = 73800m;
            FedTaxBrackets.BaseTax = 1815m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 73800m;
            FedTaxBrackets.BracketEnd = 148850m;
            FedTaxBrackets.BaseTax = 10162.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 148850m;
            FedTaxBrackets.BracketEnd = 226850m;
            FedTaxBrackets.BaseTax = 28925m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 226850m;
            FedTaxBrackets.BracketEnd = 405100m;
            FedTaxBrackets.BaseTax = 50765m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 405100m;
            FedTaxBrackets.BracketEnd = 457600m;
            FedTaxBrackets.BaseTax = 109587.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 457600m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 127962.5m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 12950m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 12950m;
            FedTaxBrackets.BracketEnd = 49400m;
            FedTaxBrackets.BaseTax = 1295m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 49400m;
            FedTaxBrackets.BracketEnd = 127550m;
            FedTaxBrackets.BaseTax = 6762.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 127550m;
            FedTaxBrackets.BracketEnd = 206600m;
            FedTaxBrackets.BaseTax = 26300m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 206600m;
            FedTaxBrackets.BracketEnd = 405100m;
            FedTaxBrackets.BaseTax = 48434m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 405100m;
            FedTaxBrackets.BracketEnd = 432200m;
            FedTaxBrackets.BaseTax = 113939m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2014;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 432200m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 123424m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9225m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9225m;
            FedTaxBrackets.BracketEnd = 37450m;
            FedTaxBrackets.BaseTax = 922.5m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 37450m;
            FedTaxBrackets.BracketEnd = 90750m;
            FedTaxBrackets.BaseTax = 5156.25m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 90750m;
            FedTaxBrackets.BracketEnd = 189300m;
            FedTaxBrackets.BaseTax = 18481.25m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 189300m;
            FedTaxBrackets.BracketEnd = 411500m;
            FedTaxBrackets.BaseTax = 46075.25m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 411500m;
            FedTaxBrackets.BracketEnd = 413200m;
            FedTaxBrackets.BaseTax = 119401.25m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 413200m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 119996.25m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 18450m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 18450m;
            FedTaxBrackets.BracketEnd = 74900m;
            FedTaxBrackets.BaseTax = 1845m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 74900m;
            FedTaxBrackets.BracketEnd = 151200m;
            FedTaxBrackets.BaseTax = 10312.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 151200m;
            FedTaxBrackets.BracketEnd = 230450m;
            FedTaxBrackets.BaseTax = 29387.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 230450m;
            FedTaxBrackets.BracketEnd = 411500m;
            FedTaxBrackets.BaseTax = 51577.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 411500m;
            FedTaxBrackets.BracketEnd = 464850m;
            FedTaxBrackets.BaseTax = 111324m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 464850m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 129996.5m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 13150m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 13150m;
            FedTaxBrackets.BracketEnd = 50200m;
            FedTaxBrackets.BaseTax = 1315m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 50200m;
            FedTaxBrackets.BracketEnd = 129600m;
            FedTaxBrackets.BaseTax = 6872.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 129600m;
            FedTaxBrackets.BracketEnd = 209850m;
            FedTaxBrackets.BaseTax = 26722.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 209850m;
            FedTaxBrackets.BracketEnd = 411500m;
            FedTaxBrackets.BaseTax = 49192.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 411500m;
            FedTaxBrackets.BracketEnd = 439000m;
            FedTaxBrackets.BaseTax = 115737m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2015;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 439000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 125362m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9275m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9275m;
            FedTaxBrackets.BracketEnd = 37650m;
            FedTaxBrackets.BaseTax = 927.5m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 37650m;
            FedTaxBrackets.BracketEnd = 91150m;
            FedTaxBrackets.BaseTax = 5183.75m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 91150m;
            FedTaxBrackets.BracketEnd = 190150m;
            FedTaxBrackets.BaseTax = 18558.75m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 190150m;
            FedTaxBrackets.BracketEnd = 413350m;
            FedTaxBrackets.BaseTax = 46278.75m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 413350m;
            FedTaxBrackets.BracketEnd = 415050m;
            FedTaxBrackets.BaseTax = 119934.75m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 415050m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 120529.75m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 18550m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 18550m;
            FedTaxBrackets.BracketEnd = 75300m;
            FedTaxBrackets.BaseTax = 1855m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 75300m;
            FedTaxBrackets.BracketEnd = 151900m;
            FedTaxBrackets.BaseTax = 10367.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 151900m;
            FedTaxBrackets.BracketEnd = 231450m;
            FedTaxBrackets.BaseTax = 29517.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 231450m;
            FedTaxBrackets.BracketEnd = 413350m;
            FedTaxBrackets.BaseTax = 51791.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 413350m;
            FedTaxBrackets.BracketEnd = 466950m;
            FedTaxBrackets.BaseTax = 111818.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 466950m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 130578.5m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 13250m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 13250m;
            FedTaxBrackets.BracketEnd = 50400m;
            FedTaxBrackets.BaseTax = 1325m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 50400m;
            FedTaxBrackets.BracketEnd = 130150m;
            FedTaxBrackets.BaseTax = 6897.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 130150m;
            FedTaxBrackets.BracketEnd = 210800m;
            FedTaxBrackets.BaseTax = 26835m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 210800m;
            FedTaxBrackets.BracketEnd = 413350m;
            FedTaxBrackets.BaseTax = 49417m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 413350m;
            FedTaxBrackets.BracketEnd = 441000m;
            FedTaxBrackets.BaseTax = 116258.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2016;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 441000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 125936m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9325m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9325m;
            FedTaxBrackets.BracketEnd = 37950m;
            FedTaxBrackets.BaseTax = 932.5m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 37950m;
            FedTaxBrackets.BracketEnd = 91900m;
            FedTaxBrackets.BaseTax = 5226.25m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 91900m;
            FedTaxBrackets.BracketEnd = 191650m;
            FedTaxBrackets.BaseTax = 18713.75m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 191650m;
            FedTaxBrackets.BracketEnd = 416700m;
            FedTaxBrackets.BaseTax = 46643.75m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 416700m;
            FedTaxBrackets.BracketEnd = 418400m;
            FedTaxBrackets.BaseTax = 120910.25m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 418400m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 121505.25m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 18650m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 18650m;
            FedTaxBrackets.BracketEnd = 75900m;
            FedTaxBrackets.BaseTax = 1865m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 75900m;
            FedTaxBrackets.BracketEnd = 153100m;
            FedTaxBrackets.BaseTax = 10452.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 153100m;
            FedTaxBrackets.BracketEnd = 233350m;
            FedTaxBrackets.BaseTax = 29752.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 233350m;
            FedTaxBrackets.BracketEnd = 416700m;
            FedTaxBrackets.BaseTax = 52222.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 416700m;
            FedTaxBrackets.BracketEnd = 470700m;
            FedTaxBrackets.BaseTax = 112728m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 470700m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 131628m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 13350m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 13350m;
            FedTaxBrackets.BracketEnd = 50800m;
            FedTaxBrackets.BaseTax = 1335m;
            FedTaxBrackets.MarginalRate = 0.15m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 50800m;
            FedTaxBrackets.BracketEnd = 131200m;
            FedTaxBrackets.BaseTax = 6952.5m;
            FedTaxBrackets.MarginalRate = 0.25m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 131200m;
            FedTaxBrackets.BracketEnd = 212500m;
            FedTaxBrackets.BaseTax = 27052.5m;
            FedTaxBrackets.MarginalRate = 0.28m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 212500m;
            FedTaxBrackets.BracketEnd = 416700m;
            FedTaxBrackets.BaseTax = 49816.5m;
            FedTaxBrackets.MarginalRate = 0.33m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 416700m;
            FedTaxBrackets.BracketEnd = 444550m;
            FedTaxBrackets.BaseTax = 117202.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2017;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 444550m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 126950m;
            FedTaxBrackets.MarginalRate = 0.396m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9525m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9525m;
            FedTaxBrackets.BracketEnd = 38700m;
            FedTaxBrackets.BaseTax = 952.5m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 38700m;
            FedTaxBrackets.BracketEnd = 82500m;
            FedTaxBrackets.BaseTax = 4453.5m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 82500m;
            FedTaxBrackets.BracketEnd = 157500m;
            FedTaxBrackets.BaseTax = 14089.5m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 157500m;
            FedTaxBrackets.BracketEnd = 200000m;
            FedTaxBrackets.BaseTax = 32089.5m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 200000m;
            FedTaxBrackets.BracketEnd = 500000m;
            FedTaxBrackets.BaseTax = 45689.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 500000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 150689.5m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 19050m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 19050m;
            FedTaxBrackets.BracketEnd = 77400m;
            FedTaxBrackets.BaseTax = 1905m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 77400m;
            FedTaxBrackets.BracketEnd = 165000m;
            FedTaxBrackets.BaseTax = 8907m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 165000m;
            FedTaxBrackets.BracketEnd = 315000m;
            FedTaxBrackets.BaseTax = 28179m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 315000m;
            FedTaxBrackets.BracketEnd = 400000m;
            FedTaxBrackets.BaseTax = 64179m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 400000m;
            FedTaxBrackets.BracketEnd = 600000m;
            FedTaxBrackets.BaseTax = 91379m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 600000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 161379m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 13600m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 13600m;
            FedTaxBrackets.BracketEnd = 51800m;
            FedTaxBrackets.BaseTax = 1360m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 51800m;
            FedTaxBrackets.BracketEnd = 82500m;
            FedTaxBrackets.BaseTax = 5944m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 82500m;
            FedTaxBrackets.BracketEnd = 157500m;
            FedTaxBrackets.BaseTax = 12698m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 157500m;
            FedTaxBrackets.BracketEnd = 200000m;
            FedTaxBrackets.BaseTax = 30698m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 200000m;
            FedTaxBrackets.BracketEnd = 500000m;
            FedTaxBrackets.BaseTax = 44298m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2018;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 500000m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 149298m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 9700m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 9700m;
            FedTaxBrackets.BracketEnd = 39475m;
            FedTaxBrackets.BaseTax = 970m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 39475m;
            FedTaxBrackets.BracketEnd = 84200m;
            FedTaxBrackets.BaseTax = 4543m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 84200m;
            FedTaxBrackets.BracketEnd = 160725m;
            FedTaxBrackets.BaseTax = 14382.5m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 160725m;
            FedTaxBrackets.BracketEnd = 204100m;
            FedTaxBrackets.BaseTax = 32748.5m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 204100m;
            FedTaxBrackets.BracketEnd = 510300m;
            FedTaxBrackets.BaseTax = 46628.5m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 0;
            FedTaxBrackets.BracketStart = 510300m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 153798.5m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 19400m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 19400m;
            FedTaxBrackets.BracketEnd = 78950m;
            FedTaxBrackets.BaseTax = 1940m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 78950m;
            FedTaxBrackets.BracketEnd = 168400m;
            FedTaxBrackets.BaseTax = 9086m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 168400m;
            FedTaxBrackets.BracketEnd = 321450m;
            FedTaxBrackets.BaseTax = 28765m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 321450m;
            FedTaxBrackets.BracketEnd = 408200m;
            FedTaxBrackets.BaseTax = 65497m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 408200m;
            FedTaxBrackets.BracketEnd = 612350m;
            FedTaxBrackets.BaseTax = 93257m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 1;
            FedTaxBrackets.BracketStart = 612350m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 164709.5m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 0m;
            FedTaxBrackets.BracketEnd = 13850m;
            FedTaxBrackets.BaseTax = 0m;
            FedTaxBrackets.MarginalRate = 0.1m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 13850m;
            FedTaxBrackets.BracketEnd = 52850m;
            FedTaxBrackets.BaseTax = 1385m;
            FedTaxBrackets.MarginalRate = 0.12m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 52850m;
            FedTaxBrackets.BracketEnd = 84200m;
            FedTaxBrackets.BaseTax = 6065m;
            FedTaxBrackets.MarginalRate = 0.22m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 84200m;
            FedTaxBrackets.BracketEnd = 160700m;
            FedTaxBrackets.BaseTax = 12962m;
            FedTaxBrackets.MarginalRate = 0.24m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 160700m;
            FedTaxBrackets.BracketEnd = 204100m;
            FedTaxBrackets.BaseTax = 31322m;
            FedTaxBrackets.MarginalRate = 0.32m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 204100m;
            FedTaxBrackets.BracketEnd = 510300m;
            FedTaxBrackets.BaseTax = 45210m;
            FedTaxBrackets.MarginalRate = 0.35m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            FedTaxBrackets = new FedTaxBrackets();
            FedTaxBrackets.Year = 2019;
            FedTaxBrackets.TaxFilingStatus = 3;
            FedTaxBrackets.BracketStart = 510300m;
            FedTaxBrackets.BracketEnd = 999999999m;
            FedTaxBrackets.BaseTax = 152380m;
            FedTaxBrackets.MarginalRate = 0.37m;
            X_.FedTaxBracketsList.Add(FedTaxBrackets);

            }  // End of Load
            }
    }
