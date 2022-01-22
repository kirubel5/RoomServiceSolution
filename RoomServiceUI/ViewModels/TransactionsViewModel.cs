using RoomServiceUI.Services;
using RoomServiceUI.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.ViewModels
{
    public class TransactionsViewModel
    {
        #region Fields
        private readonly ResourceManager LocRM = new ResourceManager("RoomServiceUI.WinFormStrings", typeof(TransactionsPage).Assembly);

        #endregion
        #region Methods
        public DataTable PopulateTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add(LocRM.GetString("Number"), typeof(int));
            table.Columns.Add(LocRM.GetString("CustomerName"));
            table.Columns.Add(LocRM.GetString("ReceptionName"));
            table.Columns.Add(LocRM.GetString("Time"));

            for (int i = 0; i < MockData.MockAdminTransaction.Count; i++)
            {
                table.Rows.Add(i + 1, MockData.MockAdminTransaction[i].CustomerName, MockData.MockAdminTransaction[i].ReceptionName,
                    MockData.MockAdminTransaction[i].TransactionTime);
            }

            return table;
        } 
        #endregion
    }
}
