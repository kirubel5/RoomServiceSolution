using RoomServiceUI.Models;
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
    public partial class LoginAccountTemplate : UserControl
    {
        #region Fields
        private string id;
        private string userName;
        private Image profilePicture;
        private string userRole;
        #endregion

        public LoginAccountTemplate()
        {
            InitializeComponent();
        }

        #region Properties      
        public string Id
        {
            get { return id; }
            set { id = value;}
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; LblName.Text = value; }
        }        

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; LblRole.Text = value; }
        }       

        public Image ProfilePicture
        {
            get { return profilePicture; }
            set { profilePicture = value; PBUser.Image = value; }
        }

        #endregion

        private void LoginAccountTemplate_Click(object sender, EventArgs e)
        {
            SelectedLoginModel.Id = Id;
            SelectedLoginModel.Name = UserName;
            SelectedLoginModel.Role = UserRole;
        }
    }
}
