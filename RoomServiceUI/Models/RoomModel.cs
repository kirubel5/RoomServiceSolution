using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Models
{
    public class RoomModel
    {
        public string RoomId { get; set; }
        public string Number { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ProfilePicture { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public string ImageThree { get; set; }
        public string[] Services { get; set; }
    }
}
