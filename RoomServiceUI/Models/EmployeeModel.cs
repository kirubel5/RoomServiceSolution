using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public string IdNumber { get; set; }
        public string ProfilePicture { get; set; }
        public string ScannedDocument { get; set; }
    }
}
