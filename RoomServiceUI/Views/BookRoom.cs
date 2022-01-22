using RoomServiceUI.Models;
using RoomServiceUI.Services;
using RoomServiceUI.Templates;
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
    public partial class BookRoom : UserControl
    {
        //private static BookRoom _instance;
        private string _selectedRoomId;

        //public static BookRoom Instance
        //{
        //    get
        //    {
        //        if (_instance == null || _instance.IsDisposed)
        //            _instance = new BookRoom();

        //        return _instance;
        //    }
        //}

        public BookRoom()
        {
            InitializeComponent();
        }       

        private void BookRoom_Load(object sender, EventArgs e)
        {
            //ReceptionPage.Instance.BackButton.Visible = true;
            _selectedRoomId = SelectedRoomModel.RoomId;
            this.InitializeSelectedRoom();
        }

        #region Methods
        private void InitializeSelectedRoom()
        {
            LblRoomNumber.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Number;
            LblRoomPrice.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Price;
            LblRoomType.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Type;
            LblStatus.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Status;
            PBProfilePicture.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ProfilePicture;
            PBImageOne.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageOne;
            PBImageTwo.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageTwo;
            PBImageThree.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageThree;

            DataTable services = new DataTable();
            services.Columns.Add("");

            int i = 0;
            foreach (var item in MockData.MockRooms[int.Parse(_selectedRoomId)].Services)
            {
                services.Rows.Add(item);
                i++;
            }

            DGVServices.DataSource = services;
        }
        #endregion

        #region Events
       
        private void BtnBook_Click(object sender, EventArgs e)
        {
            //InvoiceTemplate invoice = new InvoiceTemplate();
            //invoice.CustomerName = TBUserName.Text;
            //invoice.RoomNumber = LblRoomNumber.Text;
            //invoice.Price = LblRoomPrice.Text;
            //invoice.Show();
            //invoice.BringToFront();

            MessageBox.Show("Room booked successfully", "Invoice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        #endregion
    }
}
