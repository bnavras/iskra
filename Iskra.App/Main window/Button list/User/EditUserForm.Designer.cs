namespace Iskra.App
{
    partial class EditUserForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.lPost = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bSaveUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.pCreateUser = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lEditUser = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.pCreateUser.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.lPhoneNumber);
            this.MainPanel.Controls.Add(this.lPost);
            this.MainPanel.Controls.Add(this.lBirthday);
            this.MainPanel.Controls.Add(this.lName);
            this.MainPanel.Controls.Add(this.cbPost);
            this.MainPanel.Controls.Add(this.dtpBirthDay);
            this.MainPanel.Controls.Add(this.tbPhoneNumber);
            this.MainPanel.Controls.Add(this.tbName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(361, 151);
            this.MainPanel.TabIndex = 30;
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(51, 116);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lPhoneNumber.TabIndex = 23;
            this.lPhoneNumber.Text = "Телефон:";
            // 
            // lPost
            // 
            this.lPost.AutoSize = true;
            this.lPost.Location = new System.Drawing.Point(39, 82);
            this.lPost.Name = "lPost";
            this.lPost.Size = new System.Drawing.Size(68, 13);
            this.lPost.TabIndex = 21;
            this.lPost.Text = "Должность:";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Location = new System.Drawing.Point(21, 48);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(89, 13);
            this.lBirthday.TabIndex = 20;
            this.lBirthday.Text = "Дата рождения:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(70, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(37, 13);
            this.lName.TabIndex = 19;
            this.lName.Text = "ФИО:";
            // 
            // cbPost
            // 
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(116, 78);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(210, 21);
            this.cbPost.TabIndex = 18;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(116, 45);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.ShowCheckBox = true;
            this.dtpBirthDay.Size = new System.Drawing.Size(210, 20);
            this.dtpBirthDay.TabIndex = 17;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(116, 114);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(210, 20);
            this.tbPhoneNumber.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(210, 20);
            this.tbName.TabIndex = 14;
            // 
            // bSaveUser
            // 
            this.bSaveUser.BackColor = System.Drawing.SystemColors.Window;
            this.bSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSaveUser.Location = new System.Drawing.Point(153, 14);
            this.bSaveUser.Name = "bSaveUser";
            this.bSaveUser.Size = new System.Drawing.Size(182, 31);
            this.bSaveUser.TabIndex = 3;
            this.bSaveUser.Text = "Сохранить изменения";
            this.bSaveUser.UseVisualStyleBackColor = false;
            this.bSaveUser.Click += new System.EventHandler(this.bSaveUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 2);
            this.panel3.TabIndex = 3;
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messagePanel.Location = new System.Drawing.Point(0, 48);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(361, 20);
            this.messagePanel.TabIndex = 30;
            // 
            // pCreateUser
            // 
            this.pCreateUser.BackColor = System.Drawing.SystemColors.Info;
            this.pCreateUser.Controls.Add(this.panel3);
            this.pCreateUser.Controls.Add(this.messagePanel);
            this.pCreateUser.Controls.Add(this.pSellBorderDown);
            this.pCreateUser.Controls.Add(this.bSaveUser);
            this.pCreateUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCreateUser.Location = new System.Drawing.Point(0, 205);
            this.pCreateUser.Name = "pCreateUser";
            this.pCreateUser.Size = new System.Drawing.Size(361, 68);
            this.pCreateUser.TabIndex = 29;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(362, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(362, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lEditUser
            // 
            this.lEditUser.AutoSize = true;
            this.lEditUser.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEditUser.ForeColor = System.Drawing.Color.Gray;
            this.lEditUser.Location = new System.Drawing.Point(3, 9);
            this.lEditUser.Name = "lEditUser";
            this.lEditUser.Size = new System.Drawing.Size(346, 26);
            this.lEditUser.TabIndex = 2;
            this.lEditUser.Text = "Редактирование пользователя";
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.lEditUser);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(361, 54);
            this.labelPanel.TabIndex = 28;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pCreateUser);
            this.Controls.Add(this.labelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUserForm";
            this.Text = "Искра |  Редактирование пользователя";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.pCreateUser.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.Label lPost;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bSaveUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel pCreateUser;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lEditUser;
        private System.Windows.Forms.Panel labelPanel;
    }
}