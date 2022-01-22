namespace RoomServiceUI.Views
{
    partial class EmployeesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesPage));
            this.PnlEmployeesPage = new System.Windows.Forms.Panel();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.TLPEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.PnlEmployeesPage.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlEmployeesPage
            // 
            this.PnlEmployeesPage.BackColor = System.Drawing.Color.White;
            this.PnlEmployeesPage.Controls.Add(this.BtnClear);
            this.PnlEmployeesPage.Controls.Add(this.TLPEmployees);
            this.PnlEmployeesPage.Controls.Add(this.PnlTitle);
            resources.ApplyResources(this.PnlEmployeesPage, "PnlEmployeesPage");
            this.PnlEmployeesPage.Name = "PnlEmployeesPage";
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
            // TLPEmployees
            // 
            resources.ApplyResources(this.TLPEmployees, "TLPEmployees");
            this.TLPEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLPEmployees.Name = "TLPEmployees";
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlTitle.Controls.Add(this.PnlSearch);
            resources.ApplyResources(this.PnlTitle, "PnlTitle");
            this.PnlTitle.Name = "PnlTitle";
            // 
            // PnlSearch
            // 
            resources.ApplyResources(this.PnlSearch, "PnlSearch");
            this.PnlSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSearch.Controls.Add(this.BtnSearch);
            this.PnlSearch.Controls.Add(this.TBSearch);
            this.PnlSearch.Name = "PnlSearch";
            // 
            // BtnSearch
            // 
            resources.ApplyResources(this.BtnSearch, "BtnSearch");
            this.BtnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.Black;
            this.BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearch.IconSize = 25;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TBSearch
            // 
            resources.ApplyResources(this.TBSearch, "TBSearch");
            this.TBSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.TBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.TBSearch.Name = "TBSearch";
            // 
            // EmployeesPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlEmployeesPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesPage";
            this.Load += new System.EventHandler(this.EmployeesPage_Load);
            this.PnlEmployeesPage.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEmployeesPage;
        private System.Windows.Forms.TableLayoutPanel TLPEmployees;
        private System.Windows.Forms.Panel PnlTitle;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.TextBox TBSearch;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private System.Windows.Forms.Panel PnlSearch;
    }
}