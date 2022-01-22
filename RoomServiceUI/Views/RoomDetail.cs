using RoomServiceUI.Models;
using RoomServiceUI.Services;
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
    public partial class RoomDetail : UserControl
    {
        #region Fields
       // private static RoomDetail _instance;
        private string _selectedRoomId;
        #endregion

        public RoomDetail()
        {
            InitializeComponent();
        }

        #region Properties
        //public static RoomDetail Instance
        //{
        //    get
        //    {
        //        if (_instance == null || _instance.IsDisposed)
        //            _instance = new RoomDetail();

        //        return _instance;
        //    }
        //}
        #endregion

        #region Methods
        private void InitializeSelectedRoom()
        {
            TBRoomNumber.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Number;
            TBPrice.Text = MockData.MockRooms[int.Parse(_selectedRoomId)].Price;
            PBProfilePicture.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ProfilePicture;
            PBImageOne.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageOne;
            PBImageTwo.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageTwo;
            PBImageThree.ImageLocation = MockData.MockRooms[int.Parse(_selectedRoomId)].ImageThree;
        }
        #endregion

        #region Events
        private void RoomDetail_Load(object sender, EventArgs e)
        {
            _selectedRoomId = SelectedRoomModel.RoomId;
            this.InitializeSelectedRoom();
        } 
        #endregion
    }
}
