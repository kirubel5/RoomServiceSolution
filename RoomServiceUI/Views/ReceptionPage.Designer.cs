namespace RoomServiceUI.Views
{
    partial class ReceptionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionPage));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PnlDesktop = new System.Windows.Forms.Panel();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.BtnTransactions = new FontAwesome.Sharp.IconButton();
            this.BtnRooms = new FontAwesome.Sharp.IconButton();
            this.BtnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.PanelMenu.Controls.Add(this.PnlNav);
            this.PanelMenu.Controls.Add(this.BtnLogout);
            this.PanelMenu.Controls.Add(this.BtnSettings);
            this.PanelMenu.Controls.Add(this.BtnTransactions);
            this.PanelMenu.Controls.Add(this.BtnRooms);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            resources.ApplyResources(this.PanelMenu, "PanelMenu");
            this.PanelMenu.Name = "PanelMenu";
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.PnlNav, "PnlNav");
            this.PnlNav.Name = "PnlNav";
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.BtnMenu);
            this.PanelLogo.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.PanelLogo, "PanelLogo");
            this.PanelLogo.Name = "PanelLogo";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.PanelTitle.Controls.Add(this.BtnBack);
            resources.ApplyResources(this.PanelTitle, "PanelTitle");
            this.PanelTitle.Name = "PanelTitle";
            // 
            // PnlDesktop
            // 
            this.PnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.PnlDesktop, "PnlDesktop");
            this.PnlDesktop.Name = "PnlDesktop";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.BtnBack.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnBack, "BtnBack");
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 30;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnMenu, "BtnMenu");
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
            this.pictureBox1.Image = global::RoomServiceUI.Properties.Resources.HomeBlue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ReceptionPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlDesktop);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionPage";
            this.Load += new System.EventHandler(this.ReceptionPage_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PnlNav;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnTransactions;
        private FontAwesome.Sharp.IconButton BtnRooms;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTitle;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private System.Windows.Forms.Panel PnlDesktop;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}