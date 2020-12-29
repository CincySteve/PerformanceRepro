using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    public static class X_
        {
        public static BOCalcCtlr CalcCtlr;
        public static List<BOBase> BOList;

        public static DataTable ResultsTable;
        public static DataRow CurrRow;
        public static DataRow PrevRow;

        public static List<FedTaxBrackets> FedTaxBracketsList;
        }
    }
