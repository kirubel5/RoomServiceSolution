
namespace RoomServiceUI.Templates
{
    partial class EmployeeTemplate
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblJob = new System.Windows.Forms.Label();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblName.Location = new System.Drawing.Point(89, 9);
            this.LblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 22);
            this.LblName.TabIndex = 12;
            this.LblName.Text = "Name";
            // 
            // LblJob
            // 
            this.LblJob.AutoSize = true;
            this.LblJob.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Italic);
            this.LblJob.ForeColor = System.Drawing.Color.Silver;
            this.LblJob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblJob.Location = new System.Drawing.Point(89, 31);
            this.LblJob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblJob.Name = "LblJob";
            this.LblJob.Size = new System.Drawing.Size(29, 19);
            this.LblJob.TabIndex = 11;
            this.LblJob.Text = "job";
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.PBProfilePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBProfilePicture.InitialImage = global::RoomServiceUI.Properties.Resources.user;
            this.PBProfilePicture.Location = new System.Drawing.Point(0, 0);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Padding = new System.Windows.Forms.Padding(3);
            this.PBProfilePicture.Size = new System.Drawing.Size(71, 70);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 13;
            this.PBProfilePicture.TabStop = false;
            // 
            // EmployeeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PBProfilePicture);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblJob);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(330, 70);
            this.Name = "EmployeeTemplate";
            this.Size = new System.Drawing.Size(330, 70);
            this.Click += new System.EventHandler(this.EmployeeTemplate_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblJob;
    }
}
