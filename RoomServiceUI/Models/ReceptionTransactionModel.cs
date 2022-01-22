using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Models
{
    public class ReceptionTransactionModel
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string RoomNumber { get; set; }
        public string TransactionTime { get; set; }
    }
}
