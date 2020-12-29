﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    public class BOCalc1 : BOBase
        {
        public BOCalc1()
            {
            }

        public BOCalc1(string bbName)
            : base(bbName)
            {
            BOName = BOName;
            }

        public override void BOInit()
            {
            ColNames = new string[] { BOName + "Col1", BOName + "Col2" };

            // Cache universally used BO variables. 
            base.BOInit();
            }  // BOInit

        public override void Method1(int rowIndex)
            {
            base.Method1(rowIndex);

            FedTaxBrackets fedBracket = X_.FedTaxBracketsList.Single(x => x.Year == 2019
                && x.TaxFilingStatus == 0
                && x.BracketStart == 0m
                && x.BracketEnd == 9700m);

            int colIndex = dtResults.Columns[ColNames[0]].Ordinal;
            dtResults.Rows[rowIndex].ItemArray[colIndex] = rowIndex * 5m;
            }

        public override void Method2(int rowIndex)
            {
            base.Method2(rowIndex);

            FedTaxBrackets fedBracket = X_.FedTaxBracketsList.Single(x => x.Year == 2019
                && x.TaxFilingStatus == 0
                && x.BracketStart == 0m
                && x.BracketEnd == 9700m);

            int colIndex = dtResults.Columns[ColNames[0]].Ordinal;
            dtResults.Rows[rowIndex].ItemArray[colIndex] = rowIndex / 5m;
            }
        }
    }
