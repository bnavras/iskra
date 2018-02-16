namespace Iskra.App
{
    partial class ReportsForm
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
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.bshow = new System.Windows.Forms.Button();
            this.lTo = new System.Windows.Forms.Label();
            this.lfrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lReferName = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.bExporExcel = new System.Windows.Forms.Button();
            this.cbFiltr = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pHelp = new System.Windows.Forms.Panel();
            this.LabelPanel.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.bshow);
            this.LabelPanel.Controls.Add(this.lTo);
            this.LabelPanel.Controls.Add(this.lfrom);
            this.LabelPanel.Controls.Add(this.dtpTo);
            this.LabelPanel.Controls.Add(this.dtpFrom);
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Controls.Add(this.lReferName);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(594, 80);
            this.LabelPanel.TabIndex = 12;
            // 
            // bshow
            // 
            this.bshow.BackColor = System.Drawing.SystemColors.Window;
            this.bshow.Location = new System.Drawing.Point(440, 48);
            this.bshow.Name = "bshow";
            this.bshow.Size = new System.Drawing.Size(142, 23);
            this.bshow.TabIndex = 6;
            this.bshow.Text = "Показать";
            this.bshow.UseVisualStyleBackColor = false;
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(413, 32);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(24, 13);
            this.lTo.TabIndex = 5;
            this.lTo.Text = "По:";
            // 
            // lfrom
            // 
            this.lfrom.AutoSize = true;
            this.lfrom.Location = new System.Drawing.Point(420, 7);
            this.lfrom.Name = "lfrom";
            this.lfrom.Size = new System.Drawing.Size(17, 13);
            this.lfrom.TabIndex = 4;
            this.lfrom.Text = "С:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd  MMM yyyy HH:mm";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(440, 26);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(142, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd  MMM yyyy HH:mm";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(440, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(142, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 74);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(594, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lReferName
            // 
            this.lReferName.AutoSize = true;
            this.lReferName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lReferName.ForeColor = System.Drawing.Color.Gray;
            this.lReferName.Location = new System.Drawing.Point(12, 22);
            this.lReferName.Name = "lReferName";
            this.lReferName.Size = new System.Drawing.Size(76, 26);
            this.lReferName.TabIndex = 0;
            this.lReferName.Text = "Отчёт";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.bExporExcel);
            this.pMain.Controls.Add(this.cbFiltr);
            this.pMain.Controls.Add(this.dgvProducts);
            this.pMain.Controls.Add(this.dgvCategories);
            this.pMain.Controls.Add(this.pHelp);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(594, 642);
            this.pMain.TabIndex = 13;
            // 
            // bExporExcel
            // 
            this.bExporExcel.BackColor = System.Drawing.SystemColors.Window;
            this.bExporExcel.Location = new System.Drawing.Point(416, 580);
            this.bExporExcel.Name = "bExporExcel";
            this.bExporExcel.Size = new System.Drawing.Size(166, 36);
            this.bExporExcel.TabIndex = 5;
            this.bExporExcel.Text = "Экспорт в Excel";
            this.bExporExcel.UseVisualStyleBackColor = false;
            // 
            // cbFiltr
            // 
            this.cbFiltr.FormattingEnabled = true;
            this.cbFiltr.Location = new System.Drawing.Point(82, 82);
            this.cbFiltr.Name = "cbFiltr";
            this.cbFiltr.Size = new System.Drawing.Size(60, 21);
            this.cbFiltr.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(9, 421);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(573, 152);
            this.dgvProducts.TabIndex = 0;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(9, 102);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(573, 313);
            this.dgvCategories.TabIndex = 0;
            // 
            // pHelp
            // 
            this.pHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.pHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pHelp.Location = new System.Drawing.Point(0, 622);
            this.pHelp.Name = "pHelp";
            this.pHelp.Size = new System.Drawing.Size(594, 20);
            this.pHelp.TabIndex = 3;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 642);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportsForm";
            this.Text = "Искра | Отчёт";
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lReferName;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel pHelp;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button bExporExcel;
        private System.Windows.Forms.ComboBox cbFiltr;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lfrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button bshow;
    }
}