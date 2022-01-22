namespace RoomServiceUI.Views
{
    partial class RoomDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetail));
            this.PnlRoomDetail = new System.Windows.Forms.Panel();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PBImageThree = new System.Windows.Forms.PictureBox();
            this.PBImageTwo = new System.Windows.Forms.PictureBox();
            this.PBImageOne = new System.Windows.Forms.PictureBox();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.CBServices = new System.Windows.Forms.ComboBox();
            this.CBRoomType = new System.Windows.Forms.ComboBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblServices = new System.Windows.Forms.Label();
            this.LblImages = new System.Windows.Forms.Label();
            this.TBRoomNumber = new System.Windows.Forms.TextBox();
            this.LblProfilePicture = new System.Windows.Forms.Label();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.LblRoomNumber = new System.Windows.Forms.Label();
            this.PnlRoomDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRoomDetail
            // 
            resources.ApplyResources(this.PnlRoomDetail, "PnlRoomDetail");
            this.PnlRoomDetail.Controls.Add(this.BtnSaveChanges);
            this.PnlRoomDetail.Controls.Add(this.BtnDelete);
            this.PnlRoomDetail.Controls.Add(this.LblMessage);
            this.PnlRoomDetail.Controls.Add(this.PBImageThree);
            this.PnlRoomDetail.Controls.Add(this.PBImageTwo);
            this.PnlRoomDetail.Controls.Add(this.PBImageOne);
            this.PnlRoomDetail.Controls.Add(this.PBProfilePicture);
            this.PnlRoomDetail.Controls.Add(this.CBServices);
            this.PnlRoomDetail.Controls.Add(this.CBRoomType);
            this.PnlRoomDetail.Controls.Add(this.TBPrice);
            this.PnlRoomDetail.Controls.Add(this.LblPrice);
            this.PnlRoomDetail.Controls.Add(this.LblServices);
            this.PnlRoomDetail.Controls.Add(this.LblImages);
            this.PnlRoomDetail.Controls.Add(this.TBRoomNumber);
            this.PnlRoomDetail.Controls.Add(this.LblProfilePicture);
            this.PnlRoomDetail.Controls.Add(this.LblRoomType);
            this.PnlRoomDetail.Controls.Add(this.LblRoomNumber);
            this.PnlRoomDetail.Name = "PnlRoomDetail";
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
            // LblMessage
            // 
            resources.ApplyResources(this.LblMessage, "LblMessage");
            this.LblMessage.Name = "LblMessage";
            // 
            // PBImageThree
            // 
            resources.ApplyResources(this.PBImageThree, "PBImageThree");
            this.PBImageThree.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBImageThree.Name = "PBImageThree";
            this.PBImageThree.TabStop = false;
            // 
            // PBImageTwo
            // 
            resources.ApplyResources(this.PBImageTwo, "PBImageTwo");
            this.PBImageTwo.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBImageTwo.Name = "PBImageTwo";
            this.PBImageTwo.TabStop = false;
            // 
            // PBImageOne
            // 
            resources.ApplyResources(this.PBImageOne, "PBImageOne");
            this.PBImageOne.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBImageOne.Name = "PBImageOne";
            this.PBImageOne.TabStop = false;
            // 
            // PBProfilePicture
            // 
            resources.ApplyResources(this.PBProfilePicture, "PBProfilePicture");
            this.PBProfilePicture.Image = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.TabStop = false;
            // 
            // CBServices
            // 
            resources.ApplyResources(this.CBServices, "CBServices");
            this.CBServices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBServices.FormattingEnabled = true;
            this.CBServices.Name = "CBServices";
            // 
            // CBRoomType
            // 
            resources.ApplyResources(this.CBRoomType, "CBRoomType");
            this.CBRoomType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBRoomType.FormattingEnabled = true;
            this.CBRoomType.Name = "CBRoomType";
            // 
            // TBPrice
            // 
            resources.ApplyResources(this.TBPrice, "TBPrice");
            this.TBPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPrice.Name = "TBPrice";
            // 
            // LblPrice
            // 
            resources.ApplyResources(this.LblPrice, "LblPrice");
            this.LblPrice.Name = "LblPrice";
            // 
            // LblServices
            // 
            resources.ApplyResources(this.LblServices, "LblServices");
            this.LblServices.Name = "LblServices";
            // 
            // LblImages
            // 
            resources.ApplyResources(this.LblImages, "LblImages");
            this.LblImages.Name = "LblImages";
            // 
            // TBRoomNumber
            // 
            resources.ApplyResources(this.TBRoomNumber, "TBRoomNumber");
            this.TBRoomNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBRoomNumber.Name = "TBRoomNumber";
            // 
            // LblProfilePicture
            // 
            resources.ApplyResources(this.LblProfilePicture, "LblProfilePicture");
            this.LblProfilePicture.Name = "LblProfilePicture";
            // 
            // LblRoomType
            // 
            resources.ApplyResources(this.LblRoomType, "LblRoomType");
            this.LblRoomType.Name = "LblRoomType";
            // 
            // LblRoomNumber
            // 
            resources.ApplyResources(this.LblRoomNumber, "LblRoomNumber");
            this.LblRoomNumber.Name = "LblRoomNumber";
            // 
            // RoomDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlRoomDetail);
            this.Name = "RoomDetail";
            this.Load += new System.EventHandler(this.RoomDetail_Load);
            this.PnlRoomDetail.ResumeLayout(false);
            this.PnlRoomDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlRoomDetail;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.PictureBox PBImageThree;
        private System.Windows.Forms.PictureBox PBImageTwo;
        private System.Windows.Forms.PictureBox PBImageOne;
        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.ComboBox CBServices;
        private System.Windows.Forms.ComboBox CBRoomType;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblServices;
        private System.Windows.Forms.Label LblImages;
        private System.Windows.Forms.TextBox TBRoomNumber;
        private System.Windows.Forms.Label LblProfilePicture;
        private System.Windows.Forms.Label LblRoomType;
        private System.Windows.Forms.Label LblRoomNumber;
        private System.Windows.Forms.Button BtnSaveChanges;
        private FontAwesome.Sharp.IconButton BtnDelete;
    }
}
