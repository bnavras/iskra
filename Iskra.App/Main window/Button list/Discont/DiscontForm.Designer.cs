namespace Iskra.App
{
    partial class DiscontsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscontsForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btAddDiscount = new System.Windows.Forms.Button();
            this.btDelDiscount = new System.Windows.Forms.Button();
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.bsDiscounts = new System.Windows.Forms.BindingSource(this.components);
            this.lbDiscount = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.chbArchivalDiscounts = new System.Windows.Forms.CheckBox();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiscounts)).BeginInit();
            this.savePanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(401, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Покзать архивные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.btAddDiscount);
            this.MainPanel.Controls.Add(this.btDelDiscount);
            this.MainPanel.Controls.Add(this.dgvDiscounts);
            this.MainPanel.Location = new System.Drawing.Point(-1, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(513, 288);
            this.MainPanel.TabIndex = 2;
            // 
            // btAddDiscount
            // 
            this.btAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddDiscount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddDiscount.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddDiscount.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btAddDiscount.Image")));
            this.btAddDiscount.Location = new System.Drawing.Point(472, 8);
            this.btAddDiscount.Name = "btAddDiscount";
            this.btAddDiscount.Size = new System.Drawing.Size(29, 29);
            this.btAddDiscount.TabIndex = 46;
            this.btAddDiscount.UseVisualStyleBackColor = true;
            // 
            // btDelDiscount
            // 
            this.btDelDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelDiscount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelDiscount.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelDiscount.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelDiscount.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelDiscount.Location = new System.Drawing.Point(472, 43);
            this.btDelDiscount.Name = "btDelDiscount";
            this.btDelDiscount.Size = new System.Drawing.Size(29, 29);
            this.btDelDiscount.TabIndex = 47;
            this.btDelDiscount.UseVisualStyleBackColor = true;
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.AutoGenerateColumns = false;
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.DataSource = this.bsDiscounts;
            this.dgvDiscounts.Location = new System.Drawing.Point(13, 8);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(449, 272);
            this.dgvDiscounts.TabIndex = 3;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbDiscount.ForeColor = System.Drawing.Color.Gray;
            this.lbDiscount.Location = new System.Drawing.Point(3, 9);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(90, 26);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "Скидки";
            // 
            // savePanel
            // 
            this.savePanel.BackColor = System.Drawing.SystemColors.Info;
            this.savePanel.Controls.Add(this.panel3);
            this.savePanel.Controls.Add(this.bSave);
            this.savePanel.Controls.Add(this.messegePanel);
            this.savePanel.Controls.Add(this.pSellBorderDown);
            this.savePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savePanel.Location = new System.Drawing.Point(0, 336);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(512, 83);
            this.savePanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 2);
            this.panel3.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.Window;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSave.Location = new System.Drawing.Point(258, 14);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(242, 43);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 63);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(512, 20);
            this.messegePanel.TabIndex = 3;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(512, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.chbArchivalDiscounts);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbDiscount);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(512, 49);
            this.labelPanel.TabIndex = 4;
            // 
            // chbArchivalDiscounts
            // 
            this.chbArchivalDiscounts.AutoSize = true;
            this.chbArchivalDiscounts.Location = new System.Drawing.Point(382, 17);
            this.chbArchivalDiscounts.Name = "chbArchivalDiscounts";
            this.chbArchivalDiscounts.Size = new System.Drawing.Size(127, 17);
            this.chbArchivalDiscounts.TabIndex = 2;
            this.chbArchivalDiscounts.Text = "Показать архивные";
            this.chbArchivalDiscounts.UseVisualStyleBackColor = true;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 44);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(512, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // DiscontsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 419);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DiscontsForm";
            this.Text = "Искра | Скидки";
            this.Load += new System.EventHandler(this.DiscontsForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiscounts)).EndInit();
            this.savePanel.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.CheckBox chbArchivalDiscounts;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Button btAddDiscount;
        private System.Windows.Forms.Button btDelDiscount;
        private System.Windows.Forms.BindingSource bsDiscounts;
    }
}