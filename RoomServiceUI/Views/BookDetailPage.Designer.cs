
namespace RoomServiceUI.Views
{
    partial class BookDetailPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblRoomNumber = new System.Windows.Forms.Label();
            this.LblCheckinTime = new System.Windows.Forms.Label();
            this.LblItems = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LblName
            // 
            resources.ApplyResources(this.LblName, "LblName");
            this.LblName.Name = "LblName";
            // 
            // LblRoomNumber
            // 
            resources.ApplyResources(this.LblRoomNumber, "LblRoomNumber");
            this.LblRoomNumber.Name = "LblRoomNumber";
            // 
            // LblCheckinTime
            // 
            resources.ApplyResources(this.LblCheckinTime, "LblCheckinTime");
            this.LblCheckinTime.Name = "LblCheckinTime";
            // 
            // LblItems
            // 
            resources.ApplyResources(this.LblItems, "LblItems");
            this.LblItems.Name = "LblItems";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::RoomServiceUI.Properties.Resources.user;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BookDetailPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.LblCheckinTime);
            this.Controls.Add(this.LblRoomNumber);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblRoomNumber;
        private System.Windows.Forms.Label LblCheckinTime;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
