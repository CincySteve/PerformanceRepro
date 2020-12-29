using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    
    public class BOCalcCtlr
        {
        private int maxYear = 100;
        private int maxRepeat = 10;

        protected DataTable dtResults;     // Houses BO results, many of which are used across BOs.
        protected DataRow drPrev;          // Previous Results table row
        protected DataRow drCurr;          // Current Results table row

        public BOCalcCtlr()
            {
            // Cache shorthand references to commonly used variables
            dtResults = X_.ResultsTable;
            }

        public long CalcRun()
            {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long startElapsedMs = sw.ElapsedMilliseconds;

            // This is used to enable some Linq calls in the BO Methods
            FedTaxBrackets_Load.Load();

            for (int year = 0; year <= maxYear; year++)
                {
                X_.CurrRow = X_.ResultsTable.NewRow();
                X_.ResultsTable.Rows.Add(X_.CurrRow);

                for (int colIndex = 0; colIndex < X_.ResultsTable.Columns.Count; colIndex++)
                    {
                    X_.CurrRow.ItemArray[colIndex] = 0m;
                    }
                }  // next year

            for (int repeat = 0; repeat < maxRepeat; repeat++)
                {
                for (int year = 0; year <= maxYear; year++)
                    {
                    foreach (BOBase bo in X_.BOList)
                        {
                        bo.Method1(year);
                        bo.Method2(year);

                        bo.Method1(year);
                        bo.Method2(year);
                        }
                    }  // next year
                } // next Repeat

            long elapsedMs = sw.ElapsedMilliseconds - startElapsedMs;
            return elapsedMs;
            } // CalcRun
        }
    }
