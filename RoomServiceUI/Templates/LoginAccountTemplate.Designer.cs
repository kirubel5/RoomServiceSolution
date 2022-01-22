
namespace RoomServiceUI.Templates
{
    partial class LoginAccountTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAccountTemplate));
            this.LblRole = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.PBUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRole
            // 
            resources.ApplyResources(this.LblRole, "LblRole");
            this.LblRole.ForeColor = System.Drawing.Color.Silver;
            this.LblRole.Name = "LblRole";
            // 
            // LblName
            // 
            resources.ApplyResources(this.LblName, "LblName");
            this.LblName.Name = "LblName";
            // 
            // PBUser
            // 
            this.PBUser.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PBUser, "PBUser");
            this.PBUser.Image = global::RoomServiceUI.Properties.Resources.user;
            this.PBUser.InitialImage = global::RoomServiceUI.Properties.Resources.user;
            this.PBUser.Name = "PBUser";
            this.PBUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LoginAccountTemplate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.PBUser);
            this.Name = "LoginAccountTemplate";
            this.Click += new System.EventHandler(this.LoginAccountTemplate_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox PBUser;
        private System.Windows.Forms.Panel panel1;
    }
}
