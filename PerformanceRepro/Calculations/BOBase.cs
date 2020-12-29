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

        protected int currYear;

        protected DataTable dtResults;     // Houses BO results, many of which are used across BOs.
        protected DataRow drPrev;          // Previous Results table row
        protected DataRow drCurr;          // Current Results table row
        protected DataTable dtTaxData;
        protected DataRow drTaxData;
        protected DataTable dtCalcLog;
        protected DataRow drCalcLog;

        protected DataColumn dc;

        /////////////////////
        //   PROPERTIES    //
        /////////////////////

        protected string[] ColNames { get; set; }

        /////////////////////
        //   CONSTRUCTORS  //
        /////////////////////

        /// <summary>
        /// Default constructor used only for the BOForecast derived class that has no FE Header.
        /// </summary>
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
            // Cache shorthand references to commonly used variables
            dtResults = X_.ResultsTable;
            //dtTaxData = DS_.CFS.TaxDataTable;
            //drPrev = DS_.CFS.PrevRow;  // Needed by the BeginForecast method in derived classes

            foreach (string colName in ColNames)
                X_.ResultsTable.Columns.Add(new DataColumn(colName, typeof(decimal)));
            }  // BeginForecast

        /// <summary>
        /// Cahces the previous and current Results rows, the year, and the Nature of this year (Actual or Prediction) and
        /// handles the transfer of assets when the first person dies.
        /// </summary>
        /// <param name="year"></param>
        public virtual void BeginYear(int year)
            {
            // Get the Prev and Curr Results rows and latest TaxData row
            drPrev = X_.PrevRow;
            drCurr = X_.CurrRow;
            }  // BeginYear   

        /// <summary>
        /// Handles the death of an owner, including its impact on what happens to BBs owned by that person.  The derived 
        /// methods handle recording end-of-year results in years up to and including the Base Year, which can include 
        /// NBY-generated Prediction years.
        /// </summary>
        /// <param name="year"></param>
        public virtual void EndYear(int year)
            {
            } // EndYear
        
        }
    }
