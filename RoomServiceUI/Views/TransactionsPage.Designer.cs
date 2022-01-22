namespace RoomServiceUI.Views
{
    partial class TransactionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsPage));
            this.PnlTransactionPage = new System.Windows.Forms.Panel();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.DGVTransaction = new System.Windows.Forms.DataGridView();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBFilterByTeller = new System.Windows.Forms.ComboBox();
            this.CBFilterByDate = new System.Windows.Forms.ComboBox();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnFilter = new FontAwesome.Sharp.IconButton();
            this.PnlTransactionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).BeginInit();
            this.PnlFilter.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTransactionPage
            // 
            resources.ApplyResources(this.PnlTransactionPage, "PnlTransactionPage");
            this.PnlTransactionPage.Controls.Add(this.BtnClear);
            this.PnlTransactionPage.Controls.Add(this.DGVTransaction);
            this.PnlTransactionPage.Controls.Add(this.PnlFilter);
            this.PnlTransactionPage.Controls.Add(this.PnlTitle);
            this.PnlTransactionPage.Name = "PnlTransactionPage";
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
            // 
            // PnlFilter
            // 
            resources.ApplyResources(this.PnlFilter, "PnlFilter");
            this.PnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlFilter.Controls.Add(this.DTPTo);
            this.PnlFilter.Controls.Add(this.DTPFrom);
            this.PnlFilter.Controls.Add(this.label2);
            this.PnlFilter.Controls.Add(this.label5);
            this.PnlFilter.Controls.Add(this.label4);
            this.PnlFilter.Controls.Add(this.label3);
            this.PnlFilter.Controls.Add(this.label1);
            this.PnlFilter.Controls.Add(this.CBFilterByTeller);
            this.PnlFilter.Controls.Add(this.CBFilterByDate);
            this.PnlFilter.Name = "PnlFilter";
            // 
            // DTPTo
            // 
            resources.ApplyResources(this.DTPTo, "DTPTo");
            this.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTo.Name = "DTPTo";
            // 
            // DTPFrom
            // 
            resources.ApplyResources(this.DTPFrom, "DTPFrom");
            this.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFrom.Name = "DTPFrom";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CBFilterByTeller
            // 
            resources.ApplyResources(this.CBFilterByTeller, "CBFilterByTeller");
            this.CBFilterByTeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CBFilterByTeller.FormattingEnabled = true;
            this.CBFilterByTeller.Name = "CBFilterByTeller";
            // 
            // CBFilterByDate
            // 
            resources.ApplyResources(this.CBFilterByDate, "CBFilterByDate");
            this.CBFilterByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CBFilterByDate.FormattingEnabled = true;
            this.CBFilterByDate.Name = "CBFilterByDate";
            // 
            // PnlTitle
            // 
            resources.ApplyResources(this.PnlTitle, "PnlTitle");
            this.PnlTitle.BackColor = System.Drawing.Color.White;
            this.PnlTitle.Controls.Add(this.BtnFilter);
            this.PnlTitle.Name = "PnlTitle";
            // 
            // BtnFilter
            // 
            resources.ApplyResources(this.BtnFilter, "BtnFilter");
            this.BtnFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnFilter.FlatAppearance.BorderSize = 0;
            this.BtnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.BtnFilter.IconColor = System.Drawing.Color.Black;
            this.BtnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFilter.IconSize = 25;
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.UseVisualStyleBackColor = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // TransactionsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlTransactionPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsPage";
            this.Load += new System.EventHandler(this.TransactionsPage_Load);
            this.PnlTransactionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).EndInit();
            this.PnlFilter.ResumeLayout(false);
            this.PnlFilter.PerformLayout();
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTransactionPage;
        private System.Windows.Forms.DataGridView DGVTransaction;
        private System.Windows.Forms.Panel PnlFilter;
        private System.Windows.Forms.Panel PnlTitle;
        private FontAwesome.Sharp.IconButton BtnFilter;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBFilterByDate;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBFilterByTeller;
    }
}