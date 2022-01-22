namespace RoomServiceUI.Views
{
    partial class EmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetail));
            this.PnlEmployeeDetail = new System.Windows.Forms.Panel();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.PBDocument = new System.Windows.Forms.PictureBox();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.CBJob = new System.Windows.Forms.ComboBox();
            this.TBPhoneNumber = new System.Windows.Forms.TextBox();
            this.LblJob = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TBIdNumber = new System.Windows.Forms.TextBox();
            this.TBSalary = new System.Windows.Forms.TextBox();
            this.LblIdNumber = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblDocs = new System.Windows.Forms.Label();
            this.LblProfilePicture = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlEmployeeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlEmployeeDetail
            // 
            resources.ApplyResources(this.PnlEmployeeDetail, "PnlEmployeeDetail");
            this.PnlEmployeeDetail.Controls.Add(this.BtnSaveChanges);
            this.PnlEmployeeDetail.Controls.Add(this.BtnDelete);
            this.PnlEmployeeDetail.Controls.Add(this.PBDocument);
            this.PnlEmployeeDetail.Controls.Add(this.PBProfilePicture);
            this.PnlEmployeeDetail.Controls.Add(this.CBJob);
            this.PnlEmployeeDetail.Controls.Add(this.TBPhoneNumber);
            this.PnlEmployeeDetail.Controls.Add(this.LblJob);
            this.PnlEmployeeDetail.Controls.Add(this.LblPhoneNumber);
            this.PnlEmployeeDetail.Controls.Add(this.TBIdNumber);
            this.PnlEmployeeDetail.Controls.Add(this.TBSalary);
            this.PnlEmployeeDetail.Controls.Add(this.LblIdNumber);
            this.PnlEmployeeDetail.Controls.Add(this.LblSalary);
            this.PnlEmployeeDetail.Controls.Add(this.TBAddress);
            this.PnlEmployeeDetail.Controls.Add(this.LblMessage);
            this.PnlEmployeeDetail.Controls.Add(this.LblDocs);
            this.PnlEmployeeDetail.Controls.Add(this.LblProfilePicture);
            this.PnlEmployeeDetail.Controls.Add(this.LblAddress);
            this.PnlEmployeeDetail.Controls.Add(this.TBName);
            this.PnlEmployeeDetail.Controls.Add(this.LblName);
            this.PnlEmployeeDetail.Name = "PnlEmployeeDetail";
            // 
            // BtnSaveChanges
            // 
            resources.ApplyResources(this.BtnSaveChanges, "BtnSaveChanges");
            this.BtnSaveChanges.FlatAppearance.BorderSize = 0;
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDelete.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 30;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // PBDocument
            // 
            resources.ApplyResources(this.PBDocument, "PBDocument");
            this.PBDocument.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBDocument.Name = "PBDocument";
            this.PBDocument.TabStop = false;
            // 
            // PBProfilePicture
            // 
            resources.ApplyResources(this.PBProfilePicture, "PBProfilePicture");
            this.PBProfilePicture.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.TabStop = false;
            // 
            // CBJob
            // 
            resources.ApplyResources(this.CBJob, "CBJob");
            this.CBJob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBJob.FormattingEnabled = true;
            this.CBJob.Name = "CBJob";
            // 
            // TBPhoneNumber
            // 
            resources.ApplyResources(this.TBPhoneNumber, "TBPhoneNumber");
            this.TBPhoneNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPhoneNumber.Name = "TBPhoneNumber";
            // 
            // LblJob
            // 
            resources.ApplyResources(this.LblJob, "LblJob");
            this.LblJob.Name = "LblJob";
            // 
            // LblPhoneNumber
            // 
            resources.ApplyResources(this.LblPhoneNumber, "LblPhoneNumber");
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            // 
            // TBIdNumber
            // 
            resources.ApplyResources(this.TBIdNumber, "TBIdNumber");
            this.TBIdNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIdNumber.Name = "TBIdNumber";
            // 
            // TBSalary
            // 
            resources.ApplyResources(this.TBSalary, "TBSalary");
            this.TBSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSalary.Name = "TBSalary";
            // 
            // LblIdNumber
            // 
            resources.ApplyResources(this.LblIdNumber, "LblIdNumber");
            this.LblIdNumber.Name = "LblIdNumber";
            // 
            // LblSalary
            // 
            resources.ApplyResources(this.LblSalary, "LblSalary");
            this.LblSalary.Name = "LblSalary";
            // 
            // TBAddress
            // 
            resources.ApplyResources(this.TBAddress, "TBAddress");
            this.TBAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBAddress.Name = "TBAddress";
            // 
            // LblMessage
            // 
            resources.ApplyResources(this.LblMessage, "LblMessage");
            this.LblMessage.Name = "LblMessage";
            // 
            // LblDocs
            // 
            resources.ApplyResources(this.LblDocs, "LblDocs");
            this.LblDocs.Name = "LblDocs";
            // 
            // LblProfilePicture
            // 
            resources.ApplyResources(this.LblProfilePicture, "LblProfilePicture");
            this.LblProfilePicture.Name = "LblProfilePicture";
            // 
            // LblAddress
            // 
            resources.ApplyResources(this.LblAddress, "LblAddress");
            this.LblAddress.Name = "LblAddress";
            // 
            // TBName
            // 
            resources.ApplyResources(this.TBName, "TBName");
            this.TBName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBName.Name = "TBName";
            // 
            // LblName
            // 
            resources.ApplyResources(this.LblName, "LblName");
            this.LblName.Name = "LblName";
            // 
            // EmployeeDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlEmployeeDetail);
            this.Name = "EmployeeDetail";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            this.PnlEmployeeDetail.ResumeLayout(false);
            this.PnlEmployeeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEmployeeDetail;
        private System.Windows.Forms.PictureBox PBDocument;
        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.ComboBox CBJob;
        private System.Windows.Forms.TextBox TBPhoneNumber;
        private System.Windows.Forms.Label LblJob;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TBIdNumber;
        private System.Windows.Forms.TextBox TBSalary;
        private System.Windows.Forms.Label LblIdNumber;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Label LblDocs;
        private System.Windows.Forms.Label LblProfilePicture;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private System.Windows.Forms.Button BtnSaveChanges;
    }
}
