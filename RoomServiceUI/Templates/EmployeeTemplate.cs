using RoomServiceUI.Models;
using RoomServiceUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Templates
{
    public partial class EmployeeTemplate : UserControl
    {
        #region Fields
        private string id;
        private string userName;
        private string job;
        private string profilePicture; 

        #endregion
        public EmployeeTemplate()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [Category("Custom Props")]
        public string UserName
        {
            get { return userName; }
            set { userName = value; LblName.Text = value; }
        }

        [Category("Custom Props")]
        public string Job
        {
            get { return job; }
            set { job = value; LblJob.Text = value; }
        }

        [Category("Custom Props")]
        public string ProfilePicture
        {
            get { return profilePicture; }
            set { profilePicture = value; PBProfilePicture.ImageLocation = value; }
        }
        #endregion

        private void EmployeeTemplate_Click(object sender, EventArgs e)
        {
            SelectedEmployeeModel.Id = Id;
            EmployeeDetail a = new EmployeeDetail();
            a.Dock = DockStyle.Fill;
            AdminPage.Instance.PanelDesktop.Controls.Clear();
            AdminPage.Instance.PanelDesktop.Controls.Add(a);
        }
    }
}
