namespace RoomServiceUI.Views
{
    partial class AppShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppShell));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.CardUsers = new MaterialSkin.Controls.MaterialCard();
            this.PanelUsers = new System.Windows.Forms.Panel();
            this.FPLUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogin = new FontAwesome.Sharp.IconButton();
            this.LblMessage = new System.Windows.Forms.Label();
            this.MtbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLine = new System.Windows.Forms.Panel();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            this.CardUsers.SuspendLayout();
            this.PanelUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            resources.ApplyResources(this.PnlMain, "PnlMain");
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.PnlMain.Controls.Add(this.CardUsers);
            this.PnlMain.Controls.Add(this.LblWelcome);
            this.PnlMain.Name = "PnlMain";
            // 
            // CardUsers
            // 
            resources.ApplyResources(this.CardUsers, "CardUsers");
            this.CardUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardUsers.Controls.Add(this.PanelUsers);
            this.CardUsers.Depth = 0;
            this.CardUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardUsers.Name = "CardUsers";
            // 
            // PanelUsers
            // 
            resources.ApplyResources(this.PanelUsers, "PanelUsers");
            this.PanelUsers.BackColor = System.Drawing.Color.White;
            this.PanelUsers.Controls.Add(this.FPLUsers);
            this.PanelUsers.Controls.Add(this.BtnLogin);
            this.PanelUsers.Controls.Add(this.LblMessage);
            this.PanelUsers.Controls.Add(this.MtbPassword);
            this.PanelUsers.Controls.Add(this.LblLogin);
            this.PanelUsers.Controls.Add(this.panel1);
            this.PanelUsers.Controls.Add(this.PanelLine);
            this.PanelUsers.Name = "PanelUsers";
            // 
            // FPLUsers
            // 
            resources.ApplyResources(this.FPLUsers, "FPLUsers");
            this.FPLUsers.BackColor = System.Drawing.Color.Transparent;
            this.FPLUsers.Name = "FPLUsers";
            this.FPLUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FPLUsers_MouseClick);
            // 
            // BtnLogin
            // 
            resources.ApplyResources(this.BtnLogin, "BtnLogin");
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnLogin.IconColor = System.Drawing.Color.Black;
            this.BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblMessage
            // 
            resources.ApplyResources(this.LblMessage, "LblMessage");
            this.LblMessage.Name = "LblMessage";
            // 
            // MtbPassword
            // 
            resources.ApplyResources(this.MtbPassword, "MtbPassword");
            this.MtbPassword.AnimateReadOnly = false;
            this.MtbPassword.BackColor = System.Drawing.Color.White;
            this.MtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbPassword.Depth = 0;
            this.MtbPassword.LeadingIcon = null;
            this.MtbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.MtbPassword.Name = "MtbPassword";
            this.MtbPassword.TrailingIcon = null;
            this.MtbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MtbPassword_MouseClick);
            this.MtbPassword.Leave += new System.EventHandler(this.MtbPassword_Leave);
            // 
            // LblLogin
            // 
            resources.ApplyResources(this.LblLogin, "LblLogin");
            this.LblLogin.Name = "LblLogin";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panel1.Name = "panel1";
            // 
            // PanelLine
            // 
            resources.ApplyResources(this.PanelLine, "PanelLine");
            this.PanelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.PanelLine.Name = "PanelLine";
            // 
            // LblWelcome
            // 
            resources.ApplyResources(this.LblWelcome, "LblWelcome");
            this.LblWelcome.Name = "LblWelcome";
            // 
            // AppShell
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlMain);
            this.Name = "AppShell";
            this.Load += new System.EventHandler(this.AppShell_Load);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.CardUsers.ResumeLayout(false);
            this.PanelUsers.ResumeLayout(false);
            this.PanelUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Panel PanelUsers;
        private System.Windows.Forms.Panel PanelLine;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox MtbPassword;
        private System.Windows.Forms.Label LblMessage;
        private FontAwesome.Sharp.IconButton BtnLogin;
        private MaterialSkin.Controls.MaterialCard CardUsers;
        private System.Windows.Forms.FlowLayoutPanel FPLUsers;
    }
}