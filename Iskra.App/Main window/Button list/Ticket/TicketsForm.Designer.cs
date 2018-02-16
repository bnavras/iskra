namespace Iskra.App
{
    partial class TicketsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.bCopySubscription = new System.Windows.Forms.Button();
            this.btEditSubscription = new System.Windows.Forms.Button();
            this.btAddSubscription = new System.Windows.Forms.Button();
            this.btDelSubscription = new System.Windows.Forms.Button();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.pMessageBorder = new System.Windows.Forms.Panel();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.chbArchivalDiscounts = new System.Windows.Forms.CheckBox();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbSubscription = new System.Windows.Forms.Label();
            this.cbSalesTypeFilter = new System.Windows.Forms.ComboBox();
            this.cbTimeFilter = new System.Windows.Forms.ComboBox();
            this.cbSubscriptionFilter = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bsTickets = new System.Windows.Forms.BindingSource(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.messegePanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dgvTickets);
            this.MainPanel.Controls.Add(this.bCopySubscription);
            this.MainPanel.Controls.Add(this.btEditSubscription);
            this.MainPanel.Controls.Add(this.btAddSubscription);
            this.MainPanel.Controls.Add(this.btDelSubscription);
            this.MainPanel.Controls.Add(this.messegePanel);
            this.MainPanel.Controls.Add(this.labelPanel);
            this.MainPanel.Controls.Add(this.cbSalesTypeFilter);
            this.MainPanel.Controls.Add(this.cbTimeFilter);
            this.MainPanel.Controls.Add(this.cbSubscriptionFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(580, 367);
            this.MainPanel.TabIndex = 2;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AutoGenerateColumns = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.DataSource = this.bsTickets;
            this.dgvTickets.Location = new System.Drawing.Point(9, 85);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(523, 256);
            this.dgvTickets.TabIndex = 56;
            // 
            // bCopySubscription
            // 
            this.bCopySubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCopySubscription.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bCopySubscription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bCopySubscription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bCopySubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopySubscription.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bCopySubscription.ForeColor = System.Drawing.SystemColors.Window;
            this.bCopySubscription.Image = global::Iskra.App.Properties.Resources.copy;
            this.bCopySubscription.Location = new System.Drawing.Point(538, 155);
            this.bCopySubscription.Name = "bCopySubscription";
            this.bCopySubscription.Size = new System.Drawing.Size(29, 29);
            this.bCopySubscription.TabIndex = 55;
            this.bCopySubscription.UseVisualStyleBackColor = true;
            // 
            // btEditSubscription
            // 
            this.btEditSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditSubscription.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btEditSubscription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btEditSubscription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEditSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditSubscription.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btEditSubscription.ForeColor = System.Drawing.SystemColors.Window;
            this.btEditSubscription.Image = global::Iskra.App.Properties.Resources.edit;
            this.btEditSubscription.Location = new System.Drawing.Point(538, 120);
            this.btEditSubscription.Name = "btEditSubscription";
            this.btEditSubscription.Size = new System.Drawing.Size(29, 29);
            this.btEditSubscription.TabIndex = 54;
            this.btEditSubscription.UseVisualStyleBackColor = true;
            this.btEditSubscription.Click += new System.EventHandler(this.BtEditSubscription_Click);
            // 
            // btAddSubscription
            // 
            this.btAddSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddSubscription.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddSubscription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddSubscription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSubscription.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddSubscription.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddSubscription.Image = ((System.Drawing.Image)(resources.GetObject("btAddSubscription.Image")));
            this.btAddSubscription.Location = new System.Drawing.Point(538, 85);
            this.btAddSubscription.Name = "btAddSubscription";
            this.btAddSubscription.Size = new System.Drawing.Size(29, 29);
            this.btAddSubscription.TabIndex = 52;
            this.btAddSubscription.UseVisualStyleBackColor = true;
            this.btAddSubscription.Click += new System.EventHandler(this.BtAddSubscription_Click);
            // 
            // btDelSubscription
            // 
            this.btDelSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelSubscription.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelSubscription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelSubscription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelSubscription.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelSubscription.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelSubscription.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelSubscription.Location = new System.Drawing.Point(538, 190);
            this.btDelSubscription.Name = "btDelSubscription";
            this.btDelSubscription.Size = new System.Drawing.Size(29, 29);
            this.btDelSubscription.TabIndex = 53;
            this.btDelSubscription.UseVisualStyleBackColor = true;
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Controls.Add(this.pMessageBorder);
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 347);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(580, 20);
            this.messegePanel.TabIndex = 10;
            // 
            // pMessageBorder
            // 
            this.pMessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pMessageBorder.Location = new System.Drawing.Point(1, 1);
            this.pMessageBorder.Name = "pMessageBorder";
            this.pMessageBorder.Size = new System.Drawing.Size(580, 2);
            this.pMessageBorder.TabIndex = 4;
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.chbArchivalDiscounts);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbSubscription);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(580, 53);
            this.labelPanel.TabIndex = 9;
            // 
            // chbArchivalDiscounts
            // 
            this.chbArchivalDiscounts.AutoSize = true;
            this.chbArchivalDiscounts.Location = new System.Drawing.Point(445, 18);
            this.chbArchivalDiscounts.Name = "chbArchivalDiscounts";
            this.chbArchivalDiscounts.Size = new System.Drawing.Size(127, 17);
            this.chbArchivalDiscounts.TabIndex = 3;
            this.chbArchivalDiscounts.Text = "Показать архивные";
            this.chbArchivalDiscounts.UseVisualStyleBackColor = true;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 45);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(580, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbSubscription
            // 
            this.lbSubscription.AutoSize = true;
            this.lbSubscription.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbSubscription.ForeColor = System.Drawing.Color.Gray;
            this.lbSubscription.Location = new System.Drawing.Point(3, 9);
            this.lbSubscription.Name = "lbSubscription";
            this.lbSubscription.Size = new System.Drawing.Size(148, 26);
            this.lbSubscription.TabIndex = 0;
            this.lbSubscription.Text = "Абонементы";
            // 
            // cbSalesTypeFilter
            // 
            this.cbSalesTypeFilter.FormattingEnabled = true;
            this.cbSalesTypeFilter.Location = new System.Drawing.Point(428, 59);
            this.cbSalesTypeFilter.Name = "cbSalesTypeFilter";
            this.cbSalesTypeFilter.Size = new System.Drawing.Size(104, 21);
            this.cbSalesTypeFilter.TabIndex = 2;
            // 
            // cbTimeFilter
            // 
            this.cbTimeFilter.FormattingEnabled = true;
            this.cbTimeFilter.Location = new System.Drawing.Point(236, 58);
            this.cbTimeFilter.Name = "cbTimeFilter";
            this.cbTimeFilter.Size = new System.Drawing.Size(102, 21);
            this.cbTimeFilter.TabIndex = 1;
            // 
            // cbSubscriptionFilter
            // 
            this.cbSubscriptionFilter.FormattingEnabled = true;
            this.cbSubscriptionFilter.Location = new System.Drawing.Point(9, 58);
            this.cbSubscriptionFilter.Name = "cbSubscriptionFilter";
            this.cbSubscriptionFilter.Size = new System.Drawing.Size(227, 21);
            this.cbSubscriptionFilter.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(561, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показать архивные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 367);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TicketsForm";
            this.Text = "Искра | Абонементы";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.messegePanel.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox cbSalesTypeFilter;
        private System.Windows.Forms.ComboBox cbTimeFilter;
        private System.Windows.Forms.ComboBox cbSubscriptionFilter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbSubscription;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel pMessageBorder;
        private System.Windows.Forms.Button btEditSubscription;
        private System.Windows.Forms.Button btAddSubscription;
        private System.Windows.Forms.Button btDelSubscription;
        private System.Windows.Forms.Button bCopySubscription;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.CheckBox chbArchivalDiscounts;
        private System.Windows.Forms.BindingSource bsTickets;
    }
}