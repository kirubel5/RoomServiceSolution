using RoomServiceUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomServiceUI.Services
{
    public static class MockData
    {
        public static List<RoomModel> MockRooms = new List<RoomModel>()
        { 
            new RoomModel{RoomId = "0", Number="407", Price="360", Type="Sweet", Status="Available", Services= new string[]{ "Hot Shower", "Private Bathroom" } , 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room7.jpg",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room8.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room9.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room6.jpg",},
            new RoomModel{RoomId = "1", Number="001", Price="250", Type="Sweet", Status="Available", Services= new string[]{ "Hot Shower", "Private Bathroom" }, 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room1.png",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room10.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room11.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room12.jpg",},
            new RoomModel{RoomId = "2", Number="002", Price="360", Type="Regular", Status="Available", Services= new string[]{ "Cold Shower", "Public Bathroom" }, 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room2.jpg",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room13.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room14.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room15.jpg",},
            new RoomModel{RoomId = "3", Number="101", Price="480", Type="Sweet", Status="Occupied", Services= new string[]{ "Private Bathroom" } , 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room3.jpg",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room16.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room17.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room18.jpg",},
            new RoomModel{RoomId = "4", Number="102", Price="510", Type="Regular", Status="Not Available", Services= new string[]{ "Hot Shower", "Private Bathroom" }, 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room4.jpg",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room19.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room20.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room2.jpg",},
            new RoomModel{RoomId = "5", Number="204", Price="235", Type="Regular", Status="Occupied", Services= new string[]{ "Hot Shower", "Swimming pool" } , 
            ProfilePicture = @"C:\Users\Beki\Downloads\Rooms\room5.jpg",
            ImageOne =  @"C:\Users\Beki\Downloads\Rooms\room5.jpg",
            ImageTwo =  @"C:\Users\Beki\Downloads\Rooms\room7.jpg",
            ImageThree =  @"C:\Users\Beki\Downloads\Rooms\room8.jpg",},
        };

        public static List<LoginModel> MockLoginData = new List<LoginModel>()
        {
            new LoginModel{Id="0", Role="Admin", Name="Kirubel"},
             new LoginModel{Id="1", Role="Reception", Name="Bruk"},
              new LoginModel{Id="2", Role="Reception", Name="Carmel"}
        };

        public static List<EmployeeModel> MockEmployee = new List<EmployeeModel>()
        {
             new EmployeeModel {Id="0", Name="Solomon", Job="Cleaner", Address="4 kilo", PhoneNumber="0913371844", Salary="2500", IdNumber="atr/123", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee0.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id0.jpg"},
             new EmployeeModel {Id="1", Name="Tadesse", Job="Cleaner", Address="6 kilo", PhoneNumber="0915685427", Salary="1260", IdNumber="agr/11/12", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee1.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id1.jpg"},
             new EmployeeModel {Id="2", Name="Melat", Job="Guard", Address="Megenagna", PhoneNumber="0989587458", Salary="2000", IdNumber="nhg/1212", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee2.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id2.jpg"},
             new EmployeeModel {Id="3", Name="Hirut", Job="Cleaner", Address="Arada", PhoneNumber="0965254787", Salary="1230", IdNumber="ugr/1021", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee3.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id3.jpg"},
             new EmployeeModel {Id="4", Name="Carmel", Job="Reception", Address="Kebena", PhoneNumber="0965214589", Salary="5630", IdNumber="ugr/1021", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee4.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id4.jpg"},
             new EmployeeModel {Id="5", Name="Biruk", Job="Reception", Address="Mekanisa", PhoneNumber="096321224", Salary="1235", IdNumber="ugr/1021", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee5.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id5.jpg"},
             new EmployeeModel {Id="0", Name="Tayu", Job="Guard", Address="Megenagna", PhoneNumber="0958784124", Salary="1200", IdNumber="ugr/1021", ProfilePicture=@"C:\Users\Beki\Downloads\Employees\Employee6.jpg", ScannedDocument=@"C:\Users\Beki\Downloads\Ids\Id6.jpg"},
        };

        public static List<AdminTransactionModel> MockAdminTransaction = new List<AdminTransactionModel>() 
        {
            new AdminTransactionModel {Id="0", CustomerName="Tadesse", ReceptionName="Carmel", TransactionTime="04:45:01 Jan 05 2022"},
            new AdminTransactionModel {Id="1", CustomerName="Melaku", ReceptionName="Biruk", TransactionTime="05:25:32 Jan 04 2022"},
            new AdminTransactionModel {Id="2", CustomerName="Abinet", ReceptionName="Carmel", TransactionTime="11:47:36 Jun 14 2022"},
            new AdminTransactionModel {Id="3", CustomerName="Yared", ReceptionName="Carmel", TransactionTime="12:12:25 Sep 23 2022"},
            new AdminTransactionModel {Id="4", CustomerName="Frehiwot", ReceptionName="Biruk", TransactionTime="02:48:41 Dec 31 2022"},
            new AdminTransactionModel {Id="5", CustomerName="Lome", ReceptionName="Biruk", TransactionTime="07:52:02 Jul 01 2022"},
        };

        public static List<ReceptionTransactionModel> MockReceptionTransaction = new List<ReceptionTransactionModel>()
        {
            new ReceptionTransactionModel {Id="0", CustomerName="Tadesse", RoomNumber="012", TransactionTime="04:45:01 Jan 05 2022"},
            new ReceptionTransactionModel {Id="1", CustomerName="Melaku", RoomNumber="404", TransactionTime="05:25:32 Jan 04 2022"},
            new ReceptionTransactionModel {Id="2", CustomerName="Abinet", RoomNumber="102", TransactionTime="11:47:36 Jun 14 2022"},
            new ReceptionTransactionModel {Id="3", CustomerName="Yared", RoomNumber="325", TransactionTime="12:12:25 Sep 23 2022"},
            new ReceptionTransactionModel {Id="4", CustomerName="Frehiwot", RoomNumber="320", TransactionTime="02:48:41 Dec 31 2022"},
            new ReceptionTransactionModel {Id="5", CustomerName="Lome", RoomNumber="021", TransactionTime="07:52:02 Jul 01 2022"},
        };
    }
}
