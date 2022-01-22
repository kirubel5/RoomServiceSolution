namespace RoomServiceUI.Views
{
    partial class ReceptionRoomsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionRoomsPage));
            this.PnlReceptionRooms = new System.Windows.Forms.Panel();
            this.TLPRooms = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.PnlReceptionRooms.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlReceptionRooms
            // 
            resources.ApplyResources(this.PnlReceptionRooms, "PnlReceptionRooms");
            this.PnlReceptionRooms.Controls.Add(this.TLPRooms);
            this.PnlReceptionRooms.Controls.Add(this.panel1);
            this.PnlReceptionRooms.Controls.Add(this.PnlTitle);
            this.PnlReceptionRooms.Name = "PnlReceptionRooms";
            // 
            // TLPRooms
            // 
            resources.ApplyResources(this.TLPRooms, "TLPRooms");
            this.TLPRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLPRooms.Name = "TLPRooms";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel1.Name = "panel1";
            // 
            // PnlTitle
            // 
            resources.ApplyResources(this.PnlTitle, "PnlTitle");
            this.PnlTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlTitle.Controls.Add(this.CBFilter);
            this.PnlTitle.Name = "PnlTitle";
            // 
            // CBFilter
            // 
            resources.ApplyResources(this.CBFilter, "CBFilter");
            this.CBFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Name = "CBFilter";
            // 
            // ReceptionRoomsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlReceptionRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionRoomsPage";
            this.Load += new System.EventHandler(this.ReceptionRoomsPage_Load);
            this.PnlReceptionRooms.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlReceptionRooms;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLPRooms;
    }
}