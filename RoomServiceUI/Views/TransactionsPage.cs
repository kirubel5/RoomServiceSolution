using RoomServiceUI.Services;
using RoomServiceUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Views
{
    public partial class TransactionsPage : Form
    {
        #region Fields
        private static TransactionsPage _instance;
        private readonly TransactionsViewModel _transactionsViewModel;
        #endregion

        public TransactionsPage()
        {
            InitializeComponent();

            _transactionsViewModel = new TransactionsViewModel();
        }       

        #region Properties
        public static TransactionsPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new TransactionsPage();

                return _instance;
            }
        }
        #endregion

        #region Events
        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            DGVTransaction.DataSource = _transactionsViewModel.PopulateTable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (PnlFilter.Visible == true)
                PnlFilter.Visible = false;
            else
                PnlFilter.Visible = true;
        }
        #endregion
    }
}
