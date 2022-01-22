using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Views
{
    public partial class ReceptionPage : Form
    {
        private readonly ResourceManager LocRM = new ResourceManager("RoomServiceUI.WinFormStrings",
            typeof(ReceptionPage).Assembly);

        #region Fields
        private static ReceptionPage _instance;

        private Form currentChildForm;
        private Button currentBtn;
        #endregion
        private ReceptionPage()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("am-ET");
            InitializeComponent();
            this.CollapsMenu();
        }

        #region Properties
        public static ReceptionPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ReceptionPage();

                return _instance;
            }
        }

        public Panel PanelDesktop
        {
            get { return PnlDesktop; }
            set { PnlDesktop = value; }
        }

        public IconButton BackButton
        {
            get { return BtnBack; }
            set { BtnBack = value; }
        }

        #endregion       

        #region Methods
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlDesktop.Controls.Add(childForm);
            PnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                DeactivateBtn();

                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(146, 148, 247);

                PnlNav.Location = new Point(0, currentBtn.Location.Y);
                PnlNav.Visible = true;
                PnlNav.BringToFront();
            }
        }

        private void DeactivateBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(98, 102, 244);
                PnlNav.Visible = false;
            }
        }

        private void CollapsMenu()
        {
            if (PanelMenu.Width > 200)
            {
                PanelMenu.Width = 100;
                pictureBox1.Visible = false;
                BtnMenu.Dock = DockStyle.Top;

                foreach (Button button in PanelMenu.Controls.OfType<Button>())
                {
                    button.Text = "";
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
            else
            {
                PanelMenu.Width = 230;
                pictureBox1.Visible = true;
                BtnMenu.Dock = DockStyle.None;

                BtnRooms.Text = "  " + LocRM.GetString("Rooms");
                BtnTransactions.Text = "  " + LocRM.GetString("Transactions");
                BtnSettings.Text = "  " + LocRM.GetString("Settings");
                BtnLogout.Text = "  " + LocRM.GetString("Logout");

                foreach (Button button in PanelMenu.Controls.OfType<Button>())
                {
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        #endregion

        #region Events
        private void ReceptionPage_Load(object sender, EventArgs e)
        {
            BtnBack.Visible = false;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.CollapsMenu();
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            if (currentBtn == (Button)sender)
                return;

            this.ActivateBtn((Button)sender);
            this.OpenChildForm(ReceptionRoomsPage.Instance);
        }               

        private void BtnTransactions_Click(object sender, EventArgs e)
        {
            this.ActivateBtn((Button)sender);
            this.OpenChildForm(ReceptionTransactionsPage.Instance);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            this.ActivateBtn((Button)sender);
            this.OpenChildForm(SettingsPage.Instance);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void BtnBack_Click(object sender, EventArgs e)
        {
           // BookRoom.Instance.Hide();          
        }

        #endregion
    }
}
