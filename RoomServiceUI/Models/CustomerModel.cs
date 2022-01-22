using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Models
{
    public class CustomerModel
    {
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public List<string> Items { get; set; }
    }
}
