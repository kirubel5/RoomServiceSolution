using RoomServiceUI.Services;
using RoomServiceUI.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.ViewModels
{
    public class ReceptionRoomsViewModel
    {
        public ReceptionRoomTemplate[] CreateRooms()
        {
            ReceptionRoomTemplate[] rooms = new ReceptionRoomTemplate[MockData.MockRooms.Count];

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new ReceptionRoomTemplate();
                rooms[i].RoomId = MockData.MockRooms[i].RoomId;
                rooms[i].RoomStatus = MockData.MockRooms[i].Status;
                rooms[i].RoomNumber = MockData.MockRooms[i].Number;
                rooms[i].RoomPrice = MockData.MockRooms[i].Price;
                rooms[i].RoomType = MockData.MockRooms[i].Type;
                rooms[i].ProfilePicture = MockData.MockRooms[i].ProfilePicture;             
            }

            return rooms;
        }
    }
}
