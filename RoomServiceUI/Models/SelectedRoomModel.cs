using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Models
{
    public static class SelectedRoomModel
    {
        public static string RoomId { get; set; }
        public static string Number { get; set; }
        public static string Price { get; set; }
        public static string Type { get; set; }
        public static string Status { get; set; }
        public static string ProfilePicture { get; set; }
        public static string ImageOne { get; set; }
        public static string ImageTwo { get; set; }
        public static string ImageThree { get; set; }
        public static string[] Services { get; set; }
    }
}
