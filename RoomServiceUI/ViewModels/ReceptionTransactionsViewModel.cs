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
    public class ReceptionTransactionsViewModel
    {
        #region Fields
        private readonly ResourceManager LocRM = new ResourceManager("RoomServiceUI.WinFormStrings", typeof(ReceptionTransactionsPage).Assembly);
        #endregion

        public ReceptionTransactionsViewModel()
        {

        }

        #region Properties
        #endregion

        #region Methods
        public DataTable PopulateTable()
        {
            DataTable table = new DataTable();
            
            table.Columns.Add(LocRM.GetString("Number"), typeof(int));
            table.Columns.Add(LocRM.GetString("Name"));
            table.Columns.Add(LocRM.GetString("RoomNumber"));
            table.Columns.Add(LocRM.GetString("Time"));

            for (int i = 0; i < MockData.MockReceptionTransaction.Count; i++)
            {
                table.Rows.Add(i + 1, MockData.MockReceptionTransaction[i].CustomerName, MockData.MockReceptionTransaction[i].RoomNumber,
                    MockData.MockReceptionTransaction[i].TransactionTime);
            }

            return table;
        }
        #endregion
    }
}
