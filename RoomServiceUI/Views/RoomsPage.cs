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
    public partial class RoomsPage : Form
    {
        #region  Fields
        private static RoomsPage _instance; 
        #endregion

        private RoomsPage()
        {
            InitializeComponent();
        }

        #region  Properties

        public static RoomsPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new RoomsPage();
                }

                return _instance;
            }
        }
        #endregion

        private void RoomsPage_Load(object sender, EventArgs e)
        {
            this.CreateRoomList();
        }

        #region Methods
        private void CreateRoomList()
        {
            RoomTemplate[] rooms = new RoomTemplate[MockData.MockRooms.Count];

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new RoomTemplate();
                rooms[i].RoomId = MockData.MockRooms[i].RoomId;
                rooms[i].RoomNumber = MockData.MockRooms[i].Number;
                rooms[i].RoomPrice = MockData.MockRooms[i].Price;
                rooms[i].RoomType = MockData.MockRooms[i].Type;
                rooms[i].ProfilePicture = MockData.MockRooms[i].ProfilePicture;

                if (TLPRooms.Controls.Count < 1)
                    TLPRooms.Controls.Clear();

                TLPRooms.Controls.Add(rooms[i]);
            }
        }
        #endregion
    }
}
