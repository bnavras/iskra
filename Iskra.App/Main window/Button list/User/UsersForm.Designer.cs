namespace Iskra.App
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btDelUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.chbArchivalDiscounts = new System.Windows.Forms.CheckBox();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbUsers = new System.Windows.Forms.Label();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.btChangePassword);
            this.panel4.Controls.Add(this.btEditUser);
            this.panel4.Controls.Add(this.btAddUser);
            this.panel4.Controls.Add(this.btDelUser);
            this.panel4.Controls.Add(this.dgvUsers);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 468);
            this.panel4.TabIndex = 2;
            // 
            // btChangePassword
            // 
            this.btChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChangePassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangePassword.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btChangePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.btChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btChangePassword.Image")));
            this.btChangePassword.Location = new System.Drawing.Point(604, 160);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(29, 29);
            this.btChangePassword.TabIndex = 55;
            this.btChangePassword.UseVisualStyleBackColor = true;
            this.btChangePassword.Click += new System.EventHandler(this.BtChangePasswordClick);
            // 
            // btEditUser
            // 
            this.btEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditUser.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btEditUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btEditUser.Image = global::Iskra.App.Properties.Resources.edit;
            this.btEditUser.Location = new System.Drawing.Point(604, 90);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(29, 29);
            this.btEditUser.TabIndex = 54;
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.BtEditUser_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btAddUser.Image")));
            this.btAddUser.Location = new System.Drawing.Point(604, 55);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(29, 29);
            this.btAddUser.TabIndex = 52;
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.BtAddUser_Click);
            // 
            // btDelUser
            // 
            this.btDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelUser.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelUser.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelUser.Location = new System.Drawing.Point(604, 125);
            this.btDelUser.Name = "btDelUser";
            this.btDelUser.Size = new System.Drawing.Size(29, 29);
            this.btDelUser.TabIndex = 53;
            this.btDelUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.DataSource = this.bsUsers;
            this.dgvUsers.Location = new System.Drawing.Point(12, 55);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(586, 385);
            this.dgvUsers.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(627, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показать архивные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.chbArchivalDiscounts);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbUsers);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(645, 49);
            this.labelPanel.TabIndex = 6;
            // 
            // chbArchivalDiscounts
            // 
            this.chbArchivalDiscounts.AutoSize = true;
            this.chbArchivalDiscounts.Location = new System.Drawing.Point(506, 16);
            this.chbArchivalDiscounts.Name = "chbArchivalDiscounts";
            this.chbArchivalDiscounts.Size = new System.Drawing.Size(127, 17);
            this.chbArchivalDiscounts.TabIndex = 3;
            this.chbArchivalDiscounts.Text = "Показать архивные";
            this.chbArchivalDiscounts.UseVisualStyleBackColor = true;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 44);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(645, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbUsers.ForeColor = System.Drawing.Color.Gray;
            this.lbUsers.Location = new System.Drawing.Point(3, 9);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(166, 26);
            this.lbUsers.TabIndex = 0;
            this.lbUsers.Text = "Пользователи";
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 448);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(645, 20);
            this.messegePanel.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(-1, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 2);
            this.panel3.TabIndex = 53;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 468);
            this.Controls.Add(this.messegePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UsersForm";
            this.Text = "Искра | Пользователи";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEditUser;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btDelUser;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.CheckBox chbArchivalDiscounts;
        private System.Windows.Forms.BindingSource bsUsers;
    }
}