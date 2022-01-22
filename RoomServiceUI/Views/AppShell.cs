using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomServiceUI.Models;
using RoomServiceUI.Services;
using RoomServiceUI.Templates;
using WaissLibraryStandard;

namespace RoomServiceUI.Views
{
    public partial class AppShell : Form
    {
        private Form currentChildForm;

        public AppShell()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
        }

        private void AppShell_Load(object sender, EventArgs e)
        {
            this.GetUserList();
        }

        #region Methods
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(childForm);
            PnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void GetUserList()
        {
            LoginAccountTemplate[] users = new LoginAccountTemplate[3];

            if (FPLUsers.Controls.Count < 1)
                FPLUsers.Controls.Clear();

            users[0] = new LoginAccountTemplate();
            users[0].Id = MockData.MockLoginData[0].Id;
            users[0].UserName = MockData.MockLoginData[0].Name;
            users[0].UserRole = MockData.MockLoginData[0].Role;
            FPLUsers.Controls.Add(users[0]);

            users[1] = new LoginAccountTemplate();
            users[1].Id = MockData.MockLoginData[1].Id;
            users[1].UserName = MockData.MockLoginData[1].Name;
            users[1].UserRole = MockData.MockLoginData[1].Role;
            FPLUsers.Controls.Add(users[1]);

            users[2] = new LoginAccountTemplate();
            users[2].Id = MockData.MockLoginData[2].Id;
            users[2].UserName = MockData.MockLoginData[2].Name;
            users[2].UserRole = MockData.MockLoginData[2].Role;
            FPLUsers.Controls.Add(users[2]);
        }
        #endregion

        #region Events
        private void MtbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (MtbPassword.Text == "Password")
            {
                MtbPassword.Password = true;
                MtbPassword.Text = "";
            }
        }

        private void MtbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MtbPassword.Text))
            {
                MtbPassword.Password = false;
                MtbPassword.Text = "Password";
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedLoginModel.Id))
            {

            }

            if (SelectedLoginModel.Role == "Admin")
            {
                OpenChildForm(AdminPage.Instance);
            }
            else if (SelectedLoginModel.Role == "Reception")
            {
                OpenChildForm(ReceptionPage.Instance);
            }

        }

        private void FPLUsers_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}
