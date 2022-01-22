using RoomServiceUI.Models;
using RoomServiceUI.Views;
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
    public partial class ReceptionRoomTemplate : UserControl
    {
        #region Fields
        private string roomId;
        private string roomNumber;
        private string roomStatus;
        private string roomPrice;
        private string roomType;
        private string profilePicture;
        #endregion

        public ReceptionRoomTemplate()
        {
            InitializeComponent();
        }

        #region Properties
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        public string RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; LblStatus.Text = value; }
        }
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; LblRoomNumber.Text = value; }
        }
        public string RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; LblPrice.Text = value; }
        }
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; LblRoomType.Text = value; }
        }
        public string ProfilePicture
        {
            get { return profilePicture; }
            set { profilePicture = value; PBRoom.ImageLocation = value; }
        }

        #endregion

        private void ReceptionRoomTemplate_Click(object sender, EventArgs e)
        {
            SelectedRoomModel.RoomId = RoomId;
            BookRoom a = new BookRoom();
            a.Dock = DockStyle.Fill;
            ReceptionPage.Instance.PanelDesktop.Controls.Clear();
            ReceptionPage.Instance.PanelDesktop.Controls.Add(a);
        }

        private void ReceptionRoomTemplate_Load(object sender, EventArgs e)
        {
           // PBRoom.ImageLocation = ProfilePicture;
        }
    }
}
