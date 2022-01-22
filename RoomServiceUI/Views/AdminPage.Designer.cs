namespace RoomServiceUI.Views
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PnlDesktop = new System.Windows.Forms.Panel();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.BtnTransactions = new FontAwesome.Sharp.IconButton();
            this.BtnAddEmployee = new FontAwesome.Sharp.IconButton();
            this.BtnEmployees = new FontAwesome.Sharp.IconButton();
            this.BtnAddRoom = new FontAwesome.Sharp.IconButton();
            this.BtnRooms = new FontAwesome.Sharp.IconButton();
            this.BtnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            resources.ApplyResources(this.PanelMenu, "PanelMenu");
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.PanelMenu.Controls.Add(this.PnlNav);
            this.PanelMenu.Controls.Add(this.BtnLogout);
            this.PanelMenu.Controls.Add(this.BtnSettings);
            this.PanelMenu.Controls.Add(this.BtnTransactions);
            this.PanelMenu.Controls.Add(this.BtnAddEmployee);
            this.PanelMenu.Controls.Add(this.BtnEmployees);
            this.PanelMenu.Controls.Add(this.BtnAddRoom);
            this.PanelMenu.Controls.Add(this.BtnRooms);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Name = "PanelMenu";
            // 
            // PnlNav
            // 
            resources.ApplyResources(this.PnlNav, "PnlNav");
            this.PnlNav.BackColor = System.Drawing.Color.Blue;
            this.PnlNav.Name = "PnlNav";
            // 
            // PanelLogo
            // 
            resources.ApplyResources(this.PanelLogo, "PanelLogo");
            this.PanelLogo.Controls.Add(this.BtnMenu);
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Name = "PanelLogo";
            // 
            // PanelTitle
            // 
            resources.ApplyResources(this.PanelTitle, "PanelTitle");
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.PanelTitle.Name = "PanelTitle";
            // 
            // PnlDesktop
            // 
            resources.ApplyResources(this.PnlDesktop, "PnlDesktop");
            this.PnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.PnlDesktop.Name = "PnlDesktop";
            // 
            // BtnLogout
            // 
            resources.ApplyResources(this.BtnLogout, "BtnLogout");
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnLogout.IconColor = System.Drawing.Color.White;
            this.BtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogout.IconSize = 25;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Tag = "  ውጣ";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnSettings
            // 
            resources.ApplyResources(this.BtnSettings, "BtnSettings");
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.BtnSettings.IconColor = System.Drawing.Color.White;
            this.BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSettings.IconSize = 30;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Tag = "  ሴቲንግ";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnTransactions
            // 
            resources.ApplyResources(this.BtnTransactions, "BtnTransactions");
            this.BtnTransactions.FlatAppearance.BorderSize = 0;
            this.BtnTransactions.ForeColor = System.Drawing.Color.White;
            this.BtnTransactions.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.BtnTransactions.IconColor = System.Drawing.Color.White;
            this.BtnTransactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTransactions.IconSize = 30;
            this.BtnTransactions.Name = "BtnTransactions";
            this.BtnTransactions.Tag = "  ገቢ ወጪ";
            this.BtnTransactions.UseVisualStyleBackColor = true;
            this.BtnTransactions.Click += new System.EventHandler(this.BtnTransactions_Click);
            // 
            // BtnAddEmployee
            // 
            resources.ApplyResources(this.BtnAddEmployee, "BtnAddEmployee");
            this.BtnAddEmployee.FlatAppearance.BorderSize = 0;
            this.BtnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAddEmployee.IconColor = System.Drawing.Color.White;
            this.BtnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddEmployee.IconSize = 30;
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Tag = "  ሰራተኛ ጨምር";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnEmployees
            // 
            resources.ApplyResources(this.BtnEmployees, "BtnEmployees");
            this.BtnEmployees.FlatAppearance.BorderSize = 0;
            this.BtnEmployees.ForeColor = System.Drawing.Color.White;
            this.BtnEmployees.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.BtnEmployees.IconColor = System.Drawing.Color.White;
            this.BtnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEmployees.IconSize = 30;
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Tag = "  ሰራተኞች ";
            this.BtnEmployees.UseVisualStyleBackColor = true;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // BtnAddRoom
            // 
            resources.ApplyResources(this.BtnAddRoom, "BtnAddRoom");
            this.BtnAddRoom.FlatAppearance.BorderSize = 0;
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.BtnAddRoom.IconColor = System.Drawing.Color.White;
            this.BtnAddRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddRoom.IconSize = 30;
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Tag = "  ክፍል ጨምር";
            this.BtnAddRoom.UseVisualStyleBackColor = true;
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // BtnRooms
            // 
            resources.ApplyResources(this.BtnRooms, "BtnRooms");
            this.BtnRooms.FlatAppearance.BorderSize = 0;
            this.BtnRooms.ForeColor = System.Drawing.Color.White;
            this.BtnRooms.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnRooms.IconColor = System.Drawing.Color.White;
            this.BtnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRooms.IconSize = 30;
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Tag = "  ክፍሎች";
            this.BtnRooms.UseVisualStyleBackColor = true;
            this.BtnRooms.Click += new System.EventHandler(this.BtnRooms_Click);
            // 
            // BtnMenu
            // 
            resources.ApplyResources(this.BtnMenu, "BtnMenu");
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.BtnMenu.IconColor = System.Drawing.Color.White;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 30;
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::RoomServiceUI.Properties.Resources.HomeBlue;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // AdminPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.PnlDesktop);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnRooms;
        private FontAwesome.Sharp.IconButton BtnMenu;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private FontAwesome.Sharp.IconButton BtnTransactions;
        private FontAwesome.Sharp.IconButton BtnAddEmployee;
        private FontAwesome.Sharp.IconButton BtnEmployees;
        private FontAwesome.Sharp.IconButton BtnAddRoom;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel PnlDesktop;
    }
}