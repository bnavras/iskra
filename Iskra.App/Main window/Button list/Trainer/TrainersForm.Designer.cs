namespace Iskra.App
{
    partial class TrainersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainersForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.chbArchivalTrainers = new System.Windows.Forms.CheckBox();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbTrainer = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEditTrainer = new System.Windows.Forms.Button();
            this.btAddTrainer = new System.Windows.Forms.Button();
            this.btDelTrainer = new System.Windows.Forms.Button();
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.bsTrainers = new System.Windows.Forms.BindingSource(this.components);
            this.labelPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(393, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показать архивные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.chbArchivalTrainers);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbTrainer);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(529, 53);
            this.labelPanel.TabIndex = 7;
            // 
            // chbArchivalTrainers
            // 
            this.chbArchivalTrainers.AutoSize = true;
            this.chbArchivalTrainers.Location = new System.Drawing.Point(398, 18);
            this.chbArchivalTrainers.Name = "chbArchivalTrainers";
            this.chbArchivalTrainers.Size = new System.Drawing.Size(127, 17);
            this.chbArchivalTrainers.TabIndex = 3;
            this.chbArchivalTrainers.Text = "Показать архивные";
            this.chbArchivalTrainers.UseVisualStyleBackColor = true;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 45);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(529, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbTrainer
            // 
            this.lbTrainer.AutoSize = true;
            this.lbTrainer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbTrainer.ForeColor = System.Drawing.Color.Gray;
            this.lbTrainer.Location = new System.Drawing.Point(3, 9);
            this.lbTrainer.Name = "lbTrainer";
            this.lbTrainer.Size = new System.Drawing.Size(107, 26);
            this.lbTrainer.TabIndex = 0;
            this.lbTrainer.Text = "Тренеры";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.messegePanel);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.btEditTrainer);
            this.MainPanel.Controls.Add(this.btAddTrainer);
            this.MainPanel.Controls.Add(this.btDelTrainer);
            this.MainPanel.Controls.Add(this.dgvTrainers);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(529, 512);
            this.MainPanel.TabIndex = 6;
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 492);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(529, 20);
            this.messegePanel.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(-1, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 2);
            this.panel3.TabIndex = 49;
            // 
            // btEditTrainer
            // 
            this.btEditTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditTrainer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btEditTrainer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btEditTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEditTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditTrainer.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btEditTrainer.ForeColor = System.Drawing.SystemColors.Window;
            this.btEditTrainer.Image = global::Iskra.App.Properties.Resources.edit;
            this.btEditTrainer.Location = new System.Drawing.Point(488, 104);
            this.btEditTrainer.Name = "btEditTrainer";
            this.btEditTrainer.Size = new System.Drawing.Size(29, 29);
            this.btEditTrainer.TabIndex = 48;
            this.btEditTrainer.UseVisualStyleBackColor = true;
            this.btEditTrainer.Click += new System.EventHandler(this.BtEditTrainer_Click);
            // 
            // btAddTrainer
            // 
            this.btAddTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddTrainer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddTrainer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddTrainer.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddTrainer.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddTrainer.Image = ((System.Drawing.Image)(resources.GetObject("btAddTrainer.Image")));
            this.btAddTrainer.Location = new System.Drawing.Point(488, 69);
            this.btAddTrainer.Name = "btAddTrainer";
            this.btAddTrainer.Size = new System.Drawing.Size(29, 29);
            this.btAddTrainer.TabIndex = 46;
            this.btAddTrainer.UseVisualStyleBackColor = true;
            this.btAddTrainer.Click += new System.EventHandler(this.BtAddTrainer_Click);
            // 
            // btDelTrainer
            // 
            this.btDelTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelTrainer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelTrainer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelTrainer.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelTrainer.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelTrainer.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelTrainer.Location = new System.Drawing.Point(488, 139);
            this.btDelTrainer.Name = "btDelTrainer";
            this.btDelTrainer.Size = new System.Drawing.Size(29, 29);
            this.btDelTrainer.TabIndex = 47;
            this.btDelTrainer.UseVisualStyleBackColor = true;
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.AutoGenerateColumns = false;
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.DataSource = this.bsTrainers;
            this.dgvTrainers.Location = new System.Drawing.Point(8, 69);
            this.dgvTrainers.MultiSelect = false;
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainers.Size = new System.Drawing.Size(474, 415);
            this.dgvTrainers.TabIndex = 3;
            // 
            // TrainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrainersForm";
            this.Text = "Искра | Тренеры";
            this.Load += new System.EventHandler(this.TrainersForm_Load);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbTrainer;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btAddTrainer;
        private System.Windows.Forms.Button btDelTrainer;
        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEditTrainer;
        private System.Windows.Forms.CheckBox chbArchivalTrainers;
        private System.Windows.Forms.BindingSource bsTrainers;
    }
}