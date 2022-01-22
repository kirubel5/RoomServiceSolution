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
    public partial class EmployeesPage : Form
    {
        #region Fields
        private static EmployeesPage _instance;
        #endregion

        private EmployeesPage()
        {
            InitializeComponent();
        }

        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            this.CreateEmployeeList();
        }

        #region Properties
        public static EmployeesPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new EmployeesPage();

                return _instance;
            }
        }
        #endregion

        #region Methods
        private void CreateEmployeeList()
        {
            EmployeeTemplate[] employee = new EmployeeTemplate[MockData.MockEmployee.Count];

            for (int i = 0; i < employee.Length; i++)
            {
                employee[i] = new EmployeeTemplate();
                employee[i].UserName = MockData.MockEmployee[i].Name;
                employee[i].Id = MockData.MockEmployee[i].Id;
                employee[i].Job = MockData.MockEmployee[i].Job;
                employee[i].ProfilePicture = MockData.MockEmployee[i].ProfilePicture;

                if (TLPEmployees.Controls.Count < 1)
                    TLPEmployees.Controls.Clear();

                TLPEmployees.Controls.Add(employee[i]);
            }
        }
        #endregion        
    }
}
