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
    public partial class BookDetailPage : UserControl
    {
        private static BookDetailPage _instance;

        public BookDetailPage()
        {
            InitializeComponent();
        }

        #region Properties
        //public static BookDetailPage Instance
        //{
        //    get 
        //    {
        //        if (_instance == null || _instance.IsDisposed)                
        //            _instance = new BookDetailPage();
                
        //        return _instance;
        //    }
        //}
        public string UserName
        {
            get { return LblName.Text; }
            set { LblName.Text = value; }
        }
        public string RoomNumber
        {
            get { return LblRoomNumber.Text; }
            set { LblRoomNumber.Text = value; }
        }
        public string CheckinTime
        {
            get { return LblCheckinTime.Text; }
            set { LblCheckinTime.Text = value; }
        }
        public string Items
        {
            get { return LblItems.Text; }
            set { LblItems.Text = value; }
        }
        #endregion
    }
}
