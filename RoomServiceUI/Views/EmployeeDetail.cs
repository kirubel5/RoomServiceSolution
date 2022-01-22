using RoomServiceUI.Models;
using RoomServiceUI.Services;
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
    public partial class EmployeeDetail : UserControl
    {
        private string _selectedEmployeeId;

        public EmployeeDetail()
        {
            InitializeComponent();
        }

        #region Methods
        private void InitializeSelectedRoom()
        {
            TBName.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].Name;
            TBAddress.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].Address;
            CBJob.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].Job;
            TBSalary.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].Salary;
            TBPhoneNumber.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].PhoneNumber;
            TBIdNumber.Text = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].IdNumber;

            PBProfilePicture.ImageLocation = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].ProfilePicture;
            PBDocument.ImageLocation = MockData.MockEmployee[int.Parse(_selectedEmployeeId)].ScannedDocument;           
        }
        #endregion

        #region Events
        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            _selectedEmployeeId = SelectedEmployeeModel.Id;
            this.InitializeSelectedRoom();            
        }
        #endregion

    }
}
