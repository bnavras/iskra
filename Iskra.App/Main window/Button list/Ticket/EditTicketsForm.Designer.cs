namespace Iskra.App
{
    partial class EditTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTicketsForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.gbActionTimeSubscription = new System.Windows.Forms.GroupBox();
            this.dgvActionTimeSubscription = new System.Windows.Forms.DataGridView();
            this.gbPrograms = new System.Windows.Forms.GroupBox();
            this.btEditProgram = new System.Windows.Forms.Button();
            this.btAddProgram = new System.Windows.Forms.Button();
            this.btDelProgram = new System.Windows.Forms.Button();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.cbSalesType = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.dupValidity = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.dupNominal = new System.Windows.Forms.DomainUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lSalesType = new System.Windows.Forms.Label();
            this.lValidity = new System.Windows.Forms.Label();
            this.lNumberOfVisits = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lNominal = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbEditSubscription = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.pMessageBorder = new System.Windows.Forms.Panel();
            this.bSaveSubscription = new System.Windows.Forms.Button();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.gbActionTimeSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionTimeSubscription)).BeginInit();
            this.gbPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.gbActionTimeSubscription);
            this.MainPanel.Controls.Add(this.gbPrograms);
            this.MainPanel.Controls.Add(this.cbSalesType);
            this.MainPanel.Controls.Add(this.cbTime);
            this.MainPanel.Controls.Add(this.dupValidity);
            this.MainPanel.Controls.Add(this.domainUpDown2);
            this.MainPanel.Controls.Add(this.dupNominal);
            this.MainPanel.Controls.Add(this.tbName);
            this.MainPanel.Controls.Add(this.lSalesType);
            this.MainPanel.Controls.Add(this.lValidity);
            this.MainPanel.Controls.Add(this.lNumberOfVisits);
            this.MainPanel.Controls.Add(this.lTime);
            this.MainPanel.Controls.Add(this.lNominal);
            this.MainPanel.Controls.Add(this.lName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(627, 577);
            this.MainPanel.TabIndex = 2;
            // 
            // gbActionTimeSubscription
            // 
            this.gbActionTimeSubscription.Controls.Add(this.dgvActionTimeSubscription);
            this.gbActionTimeSubscription.Location = new System.Drawing.Point(368, 59);
            this.gbActionTimeSubscription.Name = "gbActionTimeSubscription";
            this.gbActionTimeSubscription.Size = new System.Drawing.Size(245, 440);
            this.gbActionTimeSubscription.TabIndex = 26;
            this.gbActionTimeSubscription.TabStop = false;
            this.gbActionTimeSubscription.Text = "Время действия абонемента";
            // 
            // dgvActionTimeSubscription
            // 
            this.dgvActionTimeSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionTimeSubscription.Location = new System.Drawing.Point(7, 19);
            this.dgvActionTimeSubscription.Name = "dgvActionTimeSubscription";
            this.dgvActionTimeSubscription.Size = new System.Drawing.Size(232, 415);
            this.dgvActionTimeSubscription.TabIndex = 0;
            // 
            // gbPrograms
            // 
            this.gbPrograms.Controls.Add(this.btEditProgram);
            this.gbPrograms.Controls.Add(this.btAddProgram);
            this.gbPrograms.Controls.Add(this.btDelProgram);
            this.gbPrograms.Controls.Add(this.dgvPrograms);
            this.gbPrograms.Location = new System.Drawing.Point(8, 249);
            this.gbPrograms.Name = "gbPrograms";
            this.gbPrograms.Size = new System.Drawing.Size(346, 252);
            this.gbPrograms.TabIndex = 25;
            this.gbPrograms.TabStop = false;
            this.gbPrograms.Text = "Программы";
            // 
            // btEditProgram
            // 
            this.btEditProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditProgram.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btEditProgram.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btEditProgram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEditProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditProgram.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btEditProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btEditProgram.Image = global::Iskra.App.Properties.Resources.edit;
            this.btEditProgram.Location = new System.Drawing.Point(308, 49);
            this.btEditProgram.Name = "btEditProgram";
            this.btEditProgram.Size = new System.Drawing.Size(29, 29);
            this.btEditProgram.TabIndex = 51;
            this.btEditProgram.UseVisualStyleBackColor = true;
            // 
            // btAddProgram
            // 
            this.btAddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddProgram.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddProgram.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddProgram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProgram.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddProgram.Image = ((System.Drawing.Image)(resources.GetObject("btAddProgram.Image")));
            this.btAddProgram.Location = new System.Drawing.Point(308, 14);
            this.btAddProgram.Name = "btAddProgram";
            this.btAddProgram.Size = new System.Drawing.Size(29, 29);
            this.btAddProgram.TabIndex = 49;
            this.btAddProgram.UseVisualStyleBackColor = true;
            // 
            // btDelProgram
            // 
            this.btDelProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelProgram.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelProgram.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelProgram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelProgram.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelProgram.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelProgram.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelProgram.Location = new System.Drawing.Point(308, 84);
            this.btDelProgram.Name = "btDelProgram";
            this.btDelProgram.Size = new System.Drawing.Size(29, 29);
            this.btDelProgram.TabIndex = 50;
            this.btDelProgram.UseVisualStyleBackColor = true;
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Location = new System.Drawing.Point(6, 14);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.Size = new System.Drawing.Size(296, 232);
            this.dgvPrograms.TabIndex = 4;
            // 
            // cbSalesType
            // 
            this.cbSalesType.FormattingEnabled = true;
            this.cbSalesType.Location = new System.Drawing.Point(135, 224);
            this.cbSalesType.Name = "cbSalesType";
            this.cbSalesType.Size = new System.Drawing.Size(219, 21);
            this.cbSalesType.TabIndex = 24;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(135, 192);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(219, 21);
            this.cbTime.TabIndex = 23;
            // 
            // dupValidity
            // 
            this.dupValidity.Location = new System.Drawing.Point(135, 160);
            this.dupValidity.Name = "dupValidity";
            this.dupValidity.Size = new System.Drawing.Size(219, 20);
            this.dupValidity.TabIndex = 22;
            this.dupValidity.Text = "0";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(135, 129);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(219, 20);
            this.domainUpDown2.TabIndex = 21;
            this.domainUpDown2.Text = "0";
            // 
            // dupNominal
            // 
            this.dupNominal.Location = new System.Drawing.Point(135, 98);
            this.dupNominal.Name = "dupNominal";
            this.dupNominal.Size = new System.Drawing.Size(219, 20);
            this.dupNominal.TabIndex = 20;
            this.dupNominal.Text = "0";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(135, 66);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 20);
            this.tbName.TabIndex = 19;
            // 
            // lSalesType
            // 
            this.lSalesType.AutoSize = true;
            this.lSalesType.Location = new System.Drawing.Point(53, 227);
            this.lSalesType.Name = "lSalesType";
            this.lSalesType.Size = new System.Drawing.Size(76, 13);
            this.lSalesType.TabIndex = 18;
            this.lSalesType.Text = "Тип продажи:";
            // 
            // lValidity
            // 
            this.lValidity.AutoSize = true;
            this.lValidity.Location = new System.Drawing.Point(14, 162);
            this.lValidity.Name = "lValidity";
            this.lValidity.Size = new System.Drawing.Size(114, 13);
            this.lValidity.TabIndex = 17;
            this.lValidity.Text = "Срок действия(мес.):";
            // 
            // lNumberOfVisits
            // 
            this.lNumberOfVisits.AutoSize = true;
            this.lNumberOfVisits.Location = new System.Drawing.Point(28, 132);
            this.lNumberOfVisits.Name = "lNumberOfVisits";
            this.lNumberOfVisits.Size = new System.Drawing.Size(100, 13);
            this.lNumberOfVisits.TabIndex = 15;
            this.lNumberOfVisits.Text = "Всего посещений:";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(85, 195);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(43, 13);
            this.lTime.TabIndex = 16;
            this.lTime.Text = "Время:";
            // 
            // lNominal
            // 
            this.lNominal.AutoSize = true;
            this.lNominal.Location = new System.Drawing.Point(72, 102);
            this.lNominal.Name = "lNominal";
            this.lNominal.Size = new System.Drawing.Size(56, 13);
            this.lNominal.TabIndex = 14;
            this.lNominal.Text = "Номинал:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(68, 68);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(60, 13);
            this.lName.TabIndex = 13;
            this.lName.Text = "Название:";
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbEditSubscription);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(627, 53);
            this.labelPanel.TabIndex = 8;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 45);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(627, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbEditSubscription
            // 
            this.lbEditSubscription.AutoSize = true;
            this.lbEditSubscription.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbEditSubscription.ForeColor = System.Drawing.Color.Gray;
            this.lbEditSubscription.Location = new System.Drawing.Point(3, 9);
            this.lbEditSubscription.Name = "lbEditSubscription";
            this.lbEditSubscription.Size = new System.Drawing.Size(322, 26);
            this.lbEditSubscription.TabIndex = 0;
            this.lbEditSubscription.Text = "Редактирование абонемента";
            // 
            // savePanel
            // 
            this.savePanel.BackColor = System.Drawing.SystemColors.Info;
            this.savePanel.Controls.Add(this.pMessageBorder);
            this.savePanel.Controls.Add(this.bSaveSubscription);
            this.savePanel.Controls.Add(this.messegePanel);
            this.savePanel.Controls.Add(this.pSellBorderDown);
            this.savePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savePanel.Location = new System.Drawing.Point(0, 508);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(627, 69);
            this.savePanel.TabIndex = 15;
            // 
            // pMessageBorder
            // 
            this.pMessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pMessageBorder.Location = new System.Drawing.Point(0, 50);
            this.pMessageBorder.Name = "pMessageBorder";
            this.pMessageBorder.Size = new System.Drawing.Size(627, 2);
            this.pMessageBorder.TabIndex = 3;
            // 
            // bSaveSubscription
            // 
            this.bSaveSubscription.BackColor = System.Drawing.SystemColors.Window;
            this.bSaveSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSaveSubscription.Location = new System.Drawing.Point(422, 13);
            this.bSaveSubscription.Name = "bSaveSubscription";
            this.bSaveSubscription.Size = new System.Drawing.Size(188, 32);
            this.bSaveSubscription.TabIndex = 4;
            this.bSaveSubscription.Text = "Сохранить изменения";
            this.bSaveSubscription.UseVisualStyleBackColor = false;
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 49);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(627, 20);
            this.messegePanel.TabIndex = 3;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(627, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // EditTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 577);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditTicketsForm";
            this.Text = "Искра | Редактирование абонемента";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.gbActionTimeSubscription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionTimeSubscription)).EndInit();
            this.gbPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbEditSubscription;
        private System.Windows.Forms.GroupBox gbActionTimeSubscription;
        private System.Windows.Forms.GroupBox gbPrograms;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.ComboBox cbSalesType;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.DomainUpDown dupValidity;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown dupNominal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lSalesType;
        private System.Windows.Forms.Label lValidity;
        private System.Windows.Forms.Label lNumberOfVisits;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lNominal;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Panel pMessageBorder;
        private System.Windows.Forms.Button bSaveSubscription;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.DataGridView dgvActionTimeSubscription;
        private System.Windows.Forms.Button btEditProgram;
        private System.Windows.Forms.Button btAddProgram;
        private System.Windows.Forms.Button btDelProgram;
    }
}