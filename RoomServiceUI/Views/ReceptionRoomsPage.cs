using RoomServiceUI.Services;
using RoomServiceUI.Templates;
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
    public partial class ReceptionRoomsPage : Form
    {
        #region Fields
        private readonly ReceptionRoomsViewModel _receptionsRoomViewModel;
        private static ReceptionRoomsPage _instance; 
        #endregion

        private ReceptionRoomsPage()
        {
            InitializeComponent();

            _receptionsRoomViewModel = new ReceptionRoomsViewModel();
        }

        #region Properties
        public static ReceptionRoomsPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ReceptionRoomsPage();

                return _instance;
            }
        }
        #endregion

        #region Events
        private void ReceptionRoomsPage_Load(object sender, EventArgs e)
        {
            //ReceptionRoomTemplate[] rooms = new ReceptionRoomTemplate[MockData.MockRooms.Count];

            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    rooms[i] = new ReceptionRoomTemplate();
            //    rooms[i].RoomId = MockData.MockRooms[i].RoomId;
            //    rooms[i].RoomStatus = MockData.MockRooms[i].Status;
            //    rooms[i].RoomNumber =  MockData.MockRooms[i].Number;
            //    rooms[i].RoomPrice = MockData.MockRooms[i].Price;
            //    rooms[i].RoomType = MockData.MockRooms[i].Type;
            //    rooms[i].ProfilePicture = MockData.MockRooms[i].ProfilePicture;

            //    if (TLPRooms.Controls.Count < 1)
            //        TLPRooms.Controls.Clear();

            //    TLPRooms.Controls.Add(rooms[i]);
            //}

            foreach (var item in _receptionsRoomViewModel.CreateRooms())
            {
                if (TLPRooms.Controls.Count < 1)
                    TLPRooms.Controls.Clear();

                TLPRooms.Controls.Add(item);
            }
        } 
        #endregion
    }
}
