namespace Iskra.App
{
    partial class BarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarForm));
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lclient = new System.Windows.Forms.Label();
            this.lSellTickets = new System.Windows.Forms.Label();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.cbclient = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.lPayMethod = new System.Windows.Forms.Label();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.lpayment = new System.Windows.Forms.Label();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.ldiscount = new System.Windows.Forms.Label();
            this.cbCode = new System.Windows.Forms.TextBox();
            this.lсode = new System.Windows.Forms.Label();
            this.pSell = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.pPay = new System.Windows.Forms.Panel();
            this.btAddClient = new System.Windows.Forms.Button();
            this.bDeleteTable = new System.Windows.Forms.Button();
            this.bAddTable = new System.Windows.Forms.Button();
            this.LabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pSell.SuspendLayout();
            this.pPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(627, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lclient
            // 
            this.lclient.AutoSize = true;
            this.lclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lclient.Location = new System.Drawing.Point(44, 61);
            this.lclient.Name = "lclient";
            this.lclient.Size = new System.Drawing.Size(53, 15);
            this.lclient.TabIndex = 39;
            this.lclient.Text = "Клиент:";
            // 
            // lSellTickets
            // 
            this.lSellTickets.AutoSize = true;
            this.lSellTickets.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSellTickets.ForeColor = System.Drawing.Color.Gray;
            this.lSellTickets.Location = new System.Drawing.Point(12, 9);
            this.lSellTickets.Name = "lSellTickets";
            this.lSellTickets.Size = new System.Drawing.Size(194, 26);
            this.lSellTickets.TabIndex = 0;
            this.lSellTickets.Text = "Продажа из бара";
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Controls.Add(this.lSellTickets);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(626, 53);
            this.LabelPanel.TabIndex = 12;
            // 
            // cbclient
            // 
            this.cbclient.FormattingEnabled = true;
            this.cbclient.Location = new System.Drawing.Point(122, 61);
            this.cbclient.Name = "cbclient";
            this.cbclient.Size = new System.Drawing.Size(438, 21);
            this.cbclient.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 185);
            this.dataGridView1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 2);
            this.panel3.TabIndex = 3;
            // 
            // bSell
            // 
            this.bSell.BackColor = System.Drawing.SystemColors.Window;
            this.bSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSell.Location = new System.Drawing.Point(423, 14);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(192, 43);
            this.bSell.TabIndex = 4;
            this.bSell.Text = "Продать";
            this.bSell.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 20);
            this.panel2.TabIndex = 3;
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Location = new System.Drawing.Point(122, 385);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(438, 21);
            this.cbPayMethod.TabIndex = 35;
            // 
            // lPayMethod
            // 
            this.lPayMethod.AutoSize = true;
            this.lPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPayMethod.Location = new System.Drawing.Point(15, 391);
            this.lPayMethod.Name = "lPayMethod";
            this.lPayMethod.Size = new System.Drawing.Size(78, 15);
            this.lPayMethod.TabIndex = 34;
            this.lPayMethod.Text = "Тип оплаты:";
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(122, 359);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.ReadOnly = true;
            this.tbPayment.Size = new System.Drawing.Size(438, 20);
            this.tbPayment.TabIndex = 33;
            // 
            // lpayment
            // 
            this.lpayment.AutoSize = true;
            this.lpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lpayment.Location = new System.Drawing.Point(34, 360);
            this.lpayment.Name = "lpayment";
            this.lpayment.Size = new System.Drawing.Size(63, 15);
            this.lpayment.TabIndex = 32;
            this.lpayment.Text = "К оплате:";
            // 
            // cbDiscount
            // 
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(122, 121);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(438, 21);
            this.cbDiscount.TabIndex = 31;
            // 
            // ldiscount
            // 
            this.ldiscount.AutoSize = true;
            this.ldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ldiscount.Location = new System.Drawing.Point(46, 121);
            this.ldiscount.Name = "ldiscount";
            this.ldiscount.Size = new System.Drawing.Size(51, 15);
            this.ldiscount.TabIndex = 29;
            this.ldiscount.Text = "Скидка:";
            // 
            // cbCode
            // 
            this.cbCode.Location = new System.Drawing.Point(122, 91);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(438, 20);
            this.cbCode.TabIndex = 27;
            // 
            // lсode
            // 
            this.lсode.AutoSize = true;
            this.lсode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lсode.Location = new System.Drawing.Point(25, 91);
            this.lсode.Name = "lсode";
            this.lсode.Size = new System.Drawing.Size(72, 15);
            this.lсode.TabIndex = 26;
            this.lсode.Text = "Штрих-код:";
            // 
            // pSell
            // 
            this.pSell.BackColor = System.Drawing.SystemColors.Info;
            this.pSell.Controls.Add(this.panel3);
            this.pSell.Controls.Add(this.bSell);
            this.pSell.Controls.Add(this.panel2);
            this.pSell.Controls.Add(this.pSellBorderDown);
            this.pSell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSell.Location = new System.Drawing.Point(0, 441);
            this.pSell.Name = "pSell";
            this.pSell.Size = new System.Drawing.Size(626, 83);
            this.pSell.TabIndex = 13;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(627, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // pPay
            // 
            this.pPay.BackColor = System.Drawing.SystemColors.Window;
            this.pPay.Controls.Add(this.btAddClient);
            this.pPay.Controls.Add(this.cbclient);
            this.pPay.Controls.Add(this.lclient);
            this.pPay.Controls.Add(this.bDeleteTable);
            this.pPay.Controls.Add(this.bAddTable);
            this.pPay.Controls.Add(this.dataGridView1);
            this.pPay.Controls.Add(this.cbPayMethod);
            this.pPay.Controls.Add(this.lPayMethod);
            this.pPay.Controls.Add(this.tbPayment);
            this.pPay.Controls.Add(this.lpayment);
            this.pPay.Controls.Add(this.cbDiscount);
            this.pPay.Controls.Add(this.ldiscount);
            this.pPay.Controls.Add(this.cbCode);
            this.pPay.Controls.Add(this.lсode);
            this.pPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPay.Location = new System.Drawing.Point(0, 0);
            this.pPay.Name = "pPay";
            this.pPay.Size = new System.Drawing.Size(626, 524);
            this.pPay.TabIndex = 14;
            // 
            // btAddClient
            // 
            this.btAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddClient.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddClient.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btAddClient.Image")));
            this.btAddClient.Location = new System.Drawing.Point(566, 55);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(29, 29);
            this.btAddClient.TabIndex = 41;
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.BtAddClient_Click);
            // 
            // bDeleteTable
            // 
            this.bDeleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bDeleteTable.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bDeleteTable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteTable.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bDeleteTable.ForeColor = System.Drawing.SystemColors.Window;
            this.bDeleteTable.Image = global::Iskra.App.Properties.Resources.delete;
            this.bDeleteTable.Location = new System.Drawing.Point(566, 197);
            this.bDeleteTable.Name = "bDeleteTable";
            this.bDeleteTable.Size = new System.Drawing.Size(29, 29);
            this.bDeleteTable.TabIndex = 38;
            this.bDeleteTable.UseVisualStyleBackColor = true;
            // 
            // bAddTable
            // 
            this.bAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bAddTable.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bAddTable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTable.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bAddTable.ForeColor = System.Drawing.SystemColors.Window;
            this.bAddTable.Image = ((System.Drawing.Image)(resources.GetObject("bAddTable.Image")));
            this.bAddTable.Location = new System.Drawing.Point(566, 164);
            this.bAddTable.Name = "bAddTable";
            this.bAddTable.Size = new System.Drawing.Size(29, 29);
            this.bAddTable.TabIndex = 37;
            this.bAddTable.UseVisualStyleBackColor = true;
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 524);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.pSell);
            this.Controls.Add(this.pPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BarForm";
            this.Text = "Искра | Продажа из бара";
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pSell.ResumeLayout(false);
            this.pPay.ResumeLayout(false);
            this.pPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Label lclient;
        private System.Windows.Forms.Label lSellTickets;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.ComboBox cbclient;
        private System.Windows.Forms.Button bDeleteTable;
        private System.Windows.Forms.Button bAddTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.Label lPayMethod;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.Label lpayment;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Label ldiscount;
        private System.Windows.Forms.TextBox cbCode;
        private System.Windows.Forms.Label lсode;
        private System.Windows.Forms.Panel pSell;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel pPay;
    }
}