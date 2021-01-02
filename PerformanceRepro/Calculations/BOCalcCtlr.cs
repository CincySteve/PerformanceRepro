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
        private int maxRepeat = 50;

        public BOCalcCtlr()
            {
            }

        public long CalcRun()
            {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long startElapsedMs = sw.ElapsedMilliseconds;

            // Zero the starting values in the Results Table
            for (int year = 0; year <= maxYear; year++)
                {
                DataRow currRow = X_.ResultsTable.NewRow();
                X_.ResultsTable.Rows.Add(currRow);

                for (int colIndex = 0; colIndex < X_.ResultsTable.Columns.Count; colIndex++)
                    currRow.ItemArray[colIndex] = 0m;
                }  // next year

            // Perform cpu-intensive calculations
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
