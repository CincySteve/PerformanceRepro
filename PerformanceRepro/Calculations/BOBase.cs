using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceRepro
    {
    public class BOBase
        {
        protected string BOName { get; set; }
        protected string[] ColNames { get; set; }
        protected DataColumn dc;

        public BOBase()
            {
            }

        public BOBase(string boName)
            {
            BOName = boName;
            } // CalcBase

        ////////////////////////
        //  VIRTUAL METHODS   //
        ////////////////////////

        public virtual void Method1(int rowIndex) { }
        public virtual void Method2(int rowIndex) { }

        /// <summary>
        /// Initializes the BO to begin a Forecast round.  Retrieves the BBHeader and BBDetail
        /// data, initializes the Results table and caches selected variables.
        /// </summary>
        public virtual void BOInit()
            {
            // Add this BO's columns to the Results Table
            foreach (string colName in ColNames)
                X_.ResultsTable.Columns.Add(new DataColumn(colName, typeof(decimal)));
            }  // BOInit

        }
    }
