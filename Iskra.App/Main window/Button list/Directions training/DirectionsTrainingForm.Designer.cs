namespace Iskra.App
{
    partial class DirectionsTrainingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectionsTrainingForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pSave = new System.Windows.Forms.Panel();
            this.pMessageBorder = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.bSaveDirectionsTraining = new System.Windows.Forms.Button();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.chbArchivalDirectionsTraining = new System.Windows.Forms.CheckBox();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbDirectionsTraining = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dgvTrainer = new System.Windows.Forms.DataGridView();
            this.bsTrainers = new System.Windows.Forms.BindingSource(this.components);
            this.btCopyDirectionsTraining = new System.Windows.Forms.Button();
            this.dgvDirectionsTraining = new System.Windows.Forms.DataGridView();
            this.bsDirectionsTraining = new System.Windows.Forms.BindingSource(this.components);
            this.btTrainer = new System.Windows.Forms.Button();
            this.btDelTrainer = new System.Windows.Forms.Button();
            this.btAddDirectionsTraining = new System.Windows.Forms.Button();
            this.btDelDirectionsTraining = new System.Windows.Forms.Button();
            this.lTrainer = new System.Windows.Forms.Label();
            this.lDirectionsTraining = new System.Windows.Forms.Label();
            this.pSave.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectionsTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDirectionsTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(841, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показать архивные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.SystemColors.Info;
            this.pSave.Controls.Add(this.pMessageBorder);
            this.pSave.Controls.Add(this.messagePanel);
            this.pSave.Controls.Add(this.pSellBorderDown);
            this.pSave.Controls.Add(this.bSaveDirectionsTraining);
            this.pSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSave.Location = new System.Drawing.Point(0, 317);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(930, 68);
            this.pSave.TabIndex = 32;
            // 
            // pMessageBorder
            // 
            this.pMessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pMessageBorder.Location = new System.Drawing.Point(0, 48);
            this.pMessageBorder.Name = "pMessageBorder";
            this.pMessageBorder.Size = new System.Drawing.Size(930, 2);
            this.pMessageBorder.TabIndex = 3;
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messagePanel.Location = new System.Drawing.Point(0, 48);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(930, 20);
            this.messagePanel.TabIndex = 30;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(930, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // bSaveDirectionsTraining
            // 
            this.bSaveDirectionsTraining.BackColor = System.Drawing.SystemColors.Window;
            this.bSaveDirectionsTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSaveDirectionsTraining.Location = new System.Drawing.Point(718, 11);
            this.bSaveDirectionsTraining.Name = "bSaveDirectionsTraining";
            this.bSaveDirectionsTraining.Size = new System.Drawing.Size(203, 31);
            this.bSaveDirectionsTraining.TabIndex = 3;
            this.bSaveDirectionsTraining.Text = "Сохранить";
            this.bSaveDirectionsTraining.UseVisualStyleBackColor = false;
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.chbArchivalDirectionsTraining);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbDirectionsTraining);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(930, 53);
            this.labelPanel.TabIndex = 33;
            // 
            // chbArchivalDirectionsTraining
            // 
            this.chbArchivalDirectionsTraining.AutoSize = true;
            this.chbArchivalDirectionsTraining.Location = new System.Drawing.Point(791, 18);
            this.chbArchivalDirectionsTraining.Name = "chbArchivalDirectionsTraining";
            this.chbArchivalDirectionsTraining.Size = new System.Drawing.Size(127, 17);
            this.chbArchivalDirectionsTraining.TabIndex = 3;
            this.chbArchivalDirectionsTraining.Text = "Показать архивные";
            this.chbArchivalDirectionsTraining.UseVisualStyleBackColor = true;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(930, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbDirectionsTraining
            // 
            this.lbDirectionsTraining.AutoSize = true;
            this.lbDirectionsTraining.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbDirectionsTraining.ForeColor = System.Drawing.Color.Gray;
            this.lbDirectionsTraining.Location = new System.Drawing.Point(3, 9);
            this.lbDirectionsTraining.Name = "lbDirectionsTraining";
            this.lbDirectionsTraining.Size = new System.Drawing.Size(249, 26);
            this.lbDirectionsTraining.TabIndex = 0;
            this.lbDirectionsTraining.Text = "Направления занятий";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.dgvTrainer);
            this.MainPanel.Controls.Add(this.btCopyDirectionsTraining);
            this.MainPanel.Controls.Add(this.dgvDirectionsTraining);
            this.MainPanel.Controls.Add(this.btTrainer);
            this.MainPanel.Controls.Add(this.btDelTrainer);
            this.MainPanel.Controls.Add(this.btAddDirectionsTraining);
            this.MainPanel.Controls.Add(this.btDelDirectionsTraining);
            this.MainPanel.Controls.Add(this.lTrainer);
            this.MainPanel.Controls.Add(this.lDirectionsTraining);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(930, 264);
            this.MainPanel.TabIndex = 34;
            // 
            // dgvTrainer
            // 
            this.dgvTrainer.AutoGenerateColumns = false;
            this.dgvTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainer.DataSource = this.bsTrainers;
            this.dgvTrainer.Location = new System.Drawing.Point(577, 37);
            this.dgvTrainer.Name = "dgvTrainer";
            this.dgvTrainer.Size = new System.Drawing.Size(307, 211);
            this.dgvTrainer.TabIndex = 57;
            // 
            // btCopyDirectionsTraining
            // 
            this.btCopyDirectionsTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCopyDirectionsTraining.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btCopyDirectionsTraining.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btCopyDirectionsTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btCopyDirectionsTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopyDirectionsTraining.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btCopyDirectionsTraining.ForeColor = System.Drawing.SystemColors.Window;
            this.btCopyDirectionsTraining.Image = global::Iskra.App.Properties.Resources.copy;
            this.btCopyDirectionsTraining.Location = new System.Drawing.Point(537, 107);
            this.btCopyDirectionsTraining.Name = "btCopyDirectionsTraining";
            this.btCopyDirectionsTraining.Size = new System.Drawing.Size(29, 29);
            this.btCopyDirectionsTraining.TabIndex = 56;
            this.btCopyDirectionsTraining.UseVisualStyleBackColor = true;
            // 
            // dgvDirectionsTraining
            // 
            this.dgvDirectionsTraining.AutoGenerateColumns = false;
            this.dgvDirectionsTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectionsTraining.DataSource = this.bsDirectionsTraining;
            this.dgvDirectionsTraining.Location = new System.Drawing.Point(11, 37);
            this.dgvDirectionsTraining.MultiSelect = false;
            this.dgvDirectionsTraining.Name = "dgvDirectionsTraining";
            this.dgvDirectionsTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectionsTraining.Size = new System.Drawing.Size(523, 211);
            this.dgvDirectionsTraining.TabIndex = 55;
            this.dgvDirectionsTraining.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirectionsTraining_RowEnter);
            // 
            // btTrainer
            // 
            this.btTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTrainer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btTrainer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrainer.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btTrainer.ForeColor = System.Drawing.SystemColors.Window;
            this.btTrainer.Image = ((System.Drawing.Image)(resources.GetObject("btTrainer.Image")));
            this.btTrainer.Location = new System.Drawing.Point(890, 37);
            this.btTrainer.Name = "btTrainer";
            this.btTrainer.Size = new System.Drawing.Size(29, 29);
            this.btTrainer.TabIndex = 53;
            this.btTrainer.UseVisualStyleBackColor = true;
            this.btTrainer.Click += new System.EventHandler(this.BtTrainer_Click);
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
            this.btDelTrainer.Location = new System.Drawing.Point(890, 72);
            this.btDelTrainer.Name = "btDelTrainer";
            this.btDelTrainer.Size = new System.Drawing.Size(29, 29);
            this.btDelTrainer.TabIndex = 54;
            this.btDelTrainer.UseVisualStyleBackColor = true;
            // 
            // btAddDirectionsTraining
            // 
            this.btAddDirectionsTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddDirectionsTraining.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddDirectionsTraining.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddDirectionsTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddDirectionsTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddDirectionsTraining.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddDirectionsTraining.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddDirectionsTraining.Image = ((System.Drawing.Image)(resources.GetObject("btAddDirectionsTraining.Image")));
            this.btAddDirectionsTraining.Location = new System.Drawing.Point(537, 37);
            this.btAddDirectionsTraining.Name = "btAddDirectionsTraining";
            this.btAddDirectionsTraining.Size = new System.Drawing.Size(29, 29);
            this.btAddDirectionsTraining.TabIndex = 51;
            this.btAddDirectionsTraining.UseVisualStyleBackColor = true;
            // 
            // btDelDirectionsTraining
            // 
            this.btDelDirectionsTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelDirectionsTraining.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelDirectionsTraining.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelDirectionsTraining.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelDirectionsTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelDirectionsTraining.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelDirectionsTraining.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelDirectionsTraining.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelDirectionsTraining.Location = new System.Drawing.Point(537, 72);
            this.btDelDirectionsTraining.Name = "btDelDirectionsTraining";
            this.btDelDirectionsTraining.Size = new System.Drawing.Size(29, 29);
            this.btDelDirectionsTraining.TabIndex = 52;
            this.btDelDirectionsTraining.UseVisualStyleBackColor = true;
            // 
            // lTrainer
            // 
            this.lTrainer.AutoSize = true;
            this.lTrainer.Location = new System.Drawing.Point(574, 16);
            this.lTrainer.Name = "lTrainer";
            this.lTrainer.Size = new System.Drawing.Size(55, 13);
            this.lTrainer.TabIndex = 12;
            this.lTrainer.Text = "Тренеры:";
            // 
            // lDirectionsTraining
            // 
            this.lDirectionsTraining.AutoSize = true;
            this.lDirectionsTraining.Location = new System.Drawing.Point(8, 16);
            this.lDirectionsTraining.Name = "lDirectionsTraining";
            this.lDirectionsTraining.Size = new System.Drawing.Size(122, 13);
            this.lDirectionsTraining.TabIndex = 11;
            this.lDirectionsTraining.Text = "Направления занятий:";
            // 
            // DirectionsTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 385);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.pSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DirectionsTrainingForm";
            this.Text = "М";
            this.Load += new System.EventHandler(this.DirectionsTrainingForm_Load);
            this.pSave.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectionsTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDirectionsTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pSave;
        private System.Windows.Forms.Panel pMessageBorder;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Button bSaveDirectionsTraining;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbDirectionsTraining;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lTrainer;
        private System.Windows.Forms.Label lDirectionsTraining;
        private System.Windows.Forms.DataGridView dgvDirectionsTraining;
        private System.Windows.Forms.Button btTrainer;
        private System.Windows.Forms.Button btDelTrainer;
        private System.Windows.Forms.Button btAddDirectionsTraining;
        private System.Windows.Forms.Button btDelDirectionsTraining;
        private System.Windows.Forms.Button btCopyDirectionsTraining;
        private System.Windows.Forms.CheckBox chbArchivalDirectionsTraining;
        private System.Windows.Forms.DataGridView dgvTrainer;
        private System.Windows.Forms.BindingSource bsTrainers;
        private System.Windows.Forms.BindingSource bsDirectionsTraining;
    }
}