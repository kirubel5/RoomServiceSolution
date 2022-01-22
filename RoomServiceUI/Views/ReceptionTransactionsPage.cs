using RoomServiceUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Views
{
    public partial class ReceptionTransactionsPage : Form
    {
        #region Fields
        private readonly ResourceManager LocRM = new ResourceManager("RoomServiceUI.WinFormStrings", typeof(ReceptionTransactionsPage).Assembly);
        private static ReceptionTransactionsPage _instance;
        private readonly ReceptionTransactionsViewModel _receptionTransactionsViewModel;
        private BookDetailPage _bookDetailPage;

        private string _name;
        private string _roomNumber;
        private string _checkinTime;
        private string _items;
        private bool _isSelected;
        #endregion

        private ReceptionTransactionsPage()
        {
            InitializeComponent();

            _receptionTransactionsViewModel = new ReceptionTransactionsViewModel();
        }

        #region Properties
        public static ReceptionTransactionsPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ReceptionTransactionsPage();

                return _instance;
            }
        } 
        #endregion

        #region Events
        private void ReceptionTransactionsPage_Load(object sender, EventArgs e)
        {
            DGVTransaction.DataSource = _receptionTransactionsViewModel.PopulateTable();
        }
        #endregion

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            if (!_isSelected)
                return;

            DGVTransaction.Visible = false;
            BtnBack.Visible = true;
            BtnCheckout.Visible = true;
            BtnDetail.Visible = false;

            _bookDetailPage = new BookDetailPage
            {
                UserName = _name,
                RoomNumber = _roomNumber,
                CheckinTime = _checkinTime,
                Items = "Id, Black Bag",

                Dock = DockStyle.Fill
            };

            PnlTransactionDesktop.Controls.Add(_bookDetailPage);
            PnlTransactionDesktop.Tag = _bookDetailPage;
            _bookDetailPage.BringToFront();
            _bookDetailPage.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            DGVTransaction.Visible = true;
            DGVTransaction.BringToFront();
            BtnBack.Visible = false;
            BtnCheckout.Visible = false;
            BtnDetail.Visible = true;

            _isSelected = false;
            _bookDetailPage.Hide();
            _bookDetailPage.Dispose();
        }

        private void DGVTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVTransaction.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DGVTransaction.CurrentRow.Selected = true;
                _isSelected = true;

                _name = DGVTransaction.Rows[e.RowIndex].Cells[LocRM.GetString("Name")].FormattedValue.ToString();
                _roomNumber = DGVTransaction.Rows[e.RowIndex].Cells[LocRM.GetString("RoomNumber")].FormattedValue.ToString();
                _checkinTime = DGVTransaction.Rows[e.RowIndex].Cells[LocRM.GetString("Time")].FormattedValue.ToString();
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Check out?", "Check out", MessageBoxButtons.YesNo);

            if (res == DialogResult.No)
                return;


            DGVTransaction.Visible = true;
            DGVTransaction.BringToFront();
            BtnBack.Visible = false;
            BtnCheckout.Visible = false;
            BtnDetail.Visible = true;

            _isSelected = false;
            _bookDetailPage.Hide();
            _bookDetailPage.Dispose();
        }
    }
}
