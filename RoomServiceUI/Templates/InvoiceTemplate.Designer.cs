
namespace RoomServiceUI.Templates
{
    partial class InvoiceTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceTemplate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblRoomNumber = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BntCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
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
            // LblPrice
            // 
            resources.ApplyResources(this.LblPrice, "LblPrice");
            this.LblPrice.Name = "LblPrice";
            // 
            // BntCancel
            // 
            resources.ApplyResources(this.BntCancel, "BntCancel");
            this.BntCancel.Name = "BntCancel";
            this.BntCancel.UseVisualStyleBackColor = true;
            this.BntCancel.Click += new System.EventHandler(this.BntCancel_Click);
            // 
            // BtnOk
            // 
            resources.ApplyResources(this.BtnOk, "BtnOk");
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // InvoiceTemplate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BntCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblRoomNumber);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceTemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblRoomNumber;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button BntCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label5;
    }
}
