using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Templates
{
    public partial class InvoiceTemplate : UserControl
    {
        public InvoiceTemplate()
        {
            InitializeComponent();
        }

        #region Properties
        public string CustomerName
        {
            get { return LblName.Text; }
            set { LblName.Text = value; }
        }
        public string RoomNumber
        {
            get { return LblRoomNumber.Text; }
            set { LblRoomNumber.Text = value; }
        }
        public string Price
        {
            get { return LblPrice.Text; }
            set { LblPrice.Text = value; }
        }
        #endregion

        private void BntCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
