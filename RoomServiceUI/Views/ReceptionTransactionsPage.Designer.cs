
namespace RoomServiceUI.Views
{
    partial class ReceptionTransactionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionTransactionsPage));
            this.PnlTransactionDesktop = new System.Windows.Forms.Panel();
            this.DGVTransaction = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.PnlTransactionDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTransactionDesktop
            // 
            resources.ApplyResources(this.PnlTransactionDesktop, "PnlTransactionDesktop");
            this.PnlTransactionDesktop.Controls.Add(this.DGVTransaction);
            this.PnlTransactionDesktop.Name = "PnlTransactionDesktop";
            // 
            // DGVTransaction
            // 
            resources.ApplyResources(this.DGVTransaction, "DGVTransaction");
            this.DGVTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTransaction.BackgroundColor = System.Drawing.Color.White;
            this.DGVTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.DGVTransaction.MultiSelect = false;
            this.DGVTransaction.Name = "DGVTransaction";
            this.DGVTransaction.RowHeadersVisible = false;
            this.DGVTransaction.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.DGVTransaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTransaction.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.DGVTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTransaction.RowTemplate.DividerHeight = 2;
            this.DGVTransaction.RowTemplate.Height = 40;
            this.DGVTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTransaction_CellClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.BtnCheckout);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.BtnDetail);
            this.panel1.Name = "panel1";
            // 
            // BtnCheckout
            // 
            resources.ApplyResources(this.BtnCheckout, "BtnCheckout");
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.UseVisualStyleBackColor = true;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // BtnBack
            // 
            resources.ApplyResources(this.BtnBack, "BtnBack");
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDetail
            // 
            resources.ApplyResources(this.BtnDetail, "BtnDetail");
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // ReceptionTransactionsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTransactionDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionTransactionsPage";
            this.Load += new System.EventHandler(this.ReceptionTransactionsPage_Load);
            this.PnlTransactionDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTransactionDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDetail;
        private System.Windows.Forms.DataGridView DGVTransaction;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Button BtnBack;
    }
}