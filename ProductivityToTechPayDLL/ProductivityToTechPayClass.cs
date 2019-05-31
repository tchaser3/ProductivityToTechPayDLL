/* Title:           Productivity to Tech Pay DLL
 * Date:            5-30-19
 * Author:          Terry Holmes
 * 
 * Description:     This is where the matrix for productivity to tech pay is stored */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProductivityToTechPayDLL
{
    public class ProductivityToTechPayClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ProductivityToTechPayDataSet aProductivityToTechPayDataSet;
        ProductivityToTechPayDataSetTableAdapters.productivitytotechpayTableAdapter aProductivityToTechPayTableAdapter;

        InsertProductivityToTechPayEntryTableAdapters.QueriesTableAdapter aInsertProductivityToTechPayTableAdapter;

        FindProductivityToTechPayByTechPayIDDataSet aFindProductivityToTechPayByTechPayIDDataSet;
        FindProductivityToTechPayByTechPayIDDataSetTableAdapters.FindProductivityToTechPayByTechPayIDTableAdapter aFindProductivityToTechPayByTechPayIDTableAdapter;

        FindProductivityToTechPayByProductivityIDDataSet aFindProductivityToTechPayByProductivityIDDataSet;
        FindProductivityToTechPayByProductivityIDDataSetTableAdapters.FindProductivityToTechPayByProductivityIDTableAdapter aFindProductivityToTechPayByProductivityIDTableAdapter;

        public FindProductivityToTechPayByProductivityIDDataSet FindProductivityToTechPayByProductivityID(int intProductivityID)
        {
            try
            {
                aFindProductivityToTechPayByProductivityIDDataSet = new FindProductivityToTechPayByProductivityIDDataSet();
                aFindProductivityToTechPayByProductivityIDTableAdapter = new FindProductivityToTechPayByProductivityIDDataSetTableAdapters.FindProductivityToTechPayByProductivityIDTableAdapter();
                aFindProductivityToTechPayByProductivityIDTableAdapter.Fill(aFindProductivityToTechPayByProductivityIDDataSet.FindProductivityToTechPayByProductivityID, intProductivityID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity to Techpay Class // Find Productivity to Techpay By Productivity ID " + Ex.Message);
            }

            return aFindProductivityToTechPayByProductivityIDDataSet;
        }
        public FindProductivityToTechPayByTechPayIDDataSet FindProductivityToTechPayByTechPayID(int intTechPayID)
        {
            try
            {
                aFindProductivityToTechPayByTechPayIDDataSet = new FindProductivityToTechPayByTechPayIDDataSet();
                aFindProductivityToTechPayByTechPayIDTableAdapter = new FindProductivityToTechPayByTechPayIDDataSetTableAdapters.FindProductivityToTechPayByTechPayIDTableAdapter();
                aFindProductivityToTechPayByTechPayIDTableAdapter.Fill(aFindProductivityToTechPayByTechPayIDDataSet.FindProductivityToTechPayByTechPayID, intTechPayID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity To Techpay Class // Find Productivity to Techpay by Techpay ID " + Ex.Message);
            }

            return aFindProductivityToTechPayByTechPayIDDataSet;
        }
        public bool InsertProductivityToTechPay(int intProductivityID, int intTechPayID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductivityToTechPayTableAdapter = new InsertProductivityToTechPayEntryTableAdapters.QueriesTableAdapter();
                aInsertProductivityToTechPayTableAdapter.InsertProductivityToTechPay(intProductivityID, intTechPayID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity To Techpay Class // Insert Productivity To Techpay " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductivityToTechPayDataSet GetProductivityToTechPayInfo()
        {
            try
            {
                aProductivityToTechPayDataSet = new ProductivityToTechPayDataSet();
                aProductivityToTechPayTableAdapter = new ProductivityToTechPayDataSetTableAdapters.productivitytotechpayTableAdapter();
                aProductivityToTechPayTableAdapter.Fill(aProductivityToTechPayDataSet.productivitytotechpay);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity to Tech Pay Class // Get Productivity To Tech Pay Info " + Ex.Message);
            }

            return aProductivityToTechPayDataSet;
        }
        public void UpdateProductivityToTechPayDB(ProductivityToTechPayDataSet aProductivityToTechPayDataSet)
        {
            try
            {
                aProductivityToTechPayTableAdapter = new ProductivityToTechPayDataSetTableAdapters.productivitytotechpayTableAdapter();
                aProductivityToTechPayTableAdapter.Update(aProductivityToTechPayDataSet.productivitytotechpay);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity to Tech Pay Class // Get Productivity To Tech Pay Info " + Ex.Message);
            }
        }
    }
}
