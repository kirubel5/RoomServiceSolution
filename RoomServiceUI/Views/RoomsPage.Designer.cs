namespace RoomServiceUI.Views
{
    partial class RoomsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsPage));
            this.PnlRoomsPage = new System.Windows.Forms.Panel();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.TLPRooms = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.PnlRoomsPage.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlRoomsPage
            // 
            this.PnlRoomsPage.Controls.Add(this.BtnClear);
            this.PnlRoomsPage.Controls.Add(this.TLPRooms);
            this.PnlRoomsPage.Controls.Add(this.PnlTitle);
            resources.ApplyResources(this.PnlRoomsPage, "PnlRoomsPage");
            this.PnlRoomsPage.Name = "PnlRoomsPage";
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.BackColor = System.Drawing.Color.Red;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnClear.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 30;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // TLPRooms
            // 
            resources.ApplyResources(this.TLPRooms, "TLPRooms");
            this.TLPRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLPRooms.Name = "TLPRooms";
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlTitle.Controls.Add(this.CBFilter);
            resources.ApplyResources(this.PnlTitle, "PnlTitle");
            this.PnlTitle.Name = "PnlTitle";
            // 
            // CBFilter
            // 
            resources.ApplyResources(this.CBFilter, "CBFilter");
            this.CBFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Name = "CBFilter";
            // 
            // RoomsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlRoomsPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsPage";
            this.Load += new System.EventHandler(this.RoomsPage_Load);
            this.PnlRoomsPage.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlRoomsPage;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.TableLayoutPanel TLPRooms;
        private FontAwesome.Sharp.IconButton BtnClear;
    }
}