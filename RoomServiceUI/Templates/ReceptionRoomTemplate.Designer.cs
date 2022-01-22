
namespace RoomServiceUI.Templates
{
    partial class ReceptionRoomTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionRoomTemplate));
            this.PBRoom = new System.Windows.Forms.PictureBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblRoomNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRoomType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // PBRoom
            // 
            resources.ApplyResources(this.PBRoom, "PBRoom");
            this.PBRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.PBRoom.InitialImage = global::RoomServiceUI.Properties.Resources.ImagePlaceholder;
            this.PBRoom.Name = "PBRoom";
            this.PBRoom.TabStop = false;
            // 
            // LblPrice
            // 
            resources.ApplyResources(this.LblPrice, "LblPrice");
            this.LblPrice.ForeColor = System.Drawing.Color.Lime;
            this.LblPrice.Name = "LblPrice";
            // 
            // LblRoomNumber
            // 
            resources.ApplyResources(this.LblRoomNumber, "LblRoomNumber");
            this.LblRoomNumber.Name = "LblRoomNumber";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Name = "label2";
            // 
            // LblRoomType
            // 
            resources.ApplyResources(this.LblRoomType, "LblRoomType");
            this.LblRoomType.Name = "LblRoomType";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LblStatus
            // 
            resources.ApplyResources(this.LblStatus, "LblStatus");
            this.LblStatus.ForeColor = System.Drawing.Color.Blue;
            this.LblStatus.Name = "LblStatus";
            // 
            // ReceptionRoomTemplate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblRoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRoomType);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBRoom);
            this.Name = "ReceptionRoomTemplate";
            this.Load += new System.EventHandler(this.ReceptionRoomTemplate_Load);
            this.Click += new System.EventHandler(this.ReceptionRoomTemplate_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBRoom;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblStatus;
    }
}
