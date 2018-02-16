namespace Iskra.App
{
    partial class AddNewUserForm
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
            this.labelPanel = new System.Windows.Forms.Panel();
            this.lNewUser = new System.Windows.Forms.Label();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.pCreateUser = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.bCreateUser = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lPasswordObligatory = new System.Windows.Forms.Label();
            this.lPostObligatory = new System.Windows.Forms.Label();
            this.lNameobligatory = new System.Windows.Forms.Label();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lPost = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelPanel.SuspendLayout();
            this.pCreateUser.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.lNewUser);
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(362, 54);
            this.labelPanel.TabIndex = 25;
            // 
            // lNewUser
            // 
            this.lNewUser.AutoSize = true;
            this.lNewUser.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNewUser.ForeColor = System.Drawing.Color.Gray;
            this.lNewUser.Location = new System.Drawing.Point(3, 9);
            this.lNewUser.Name = "lNewUser";
            this.lNewUser.Size = new System.Drawing.Size(243, 26);
            this.lNewUser.TabIndex = 2;
            this.lNewUser.Text = "Новый пользователь";
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(362, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // pCreateUser
            // 
            this.pCreateUser.BackColor = System.Drawing.SystemColors.Info;
            this.pCreateUser.Controls.Add(this.panel3);
            this.pCreateUser.Controls.Add(this.messagePanel);
            this.pCreateUser.Controls.Add(this.pSellBorderDown);
            this.pCreateUser.Controls.Add(this.bCreateUser);
            this.pCreateUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCreateUser.Location = new System.Drawing.Point(0, 236);
            this.pCreateUser.Name = "pCreateUser";
            this.pCreateUser.Size = new System.Drawing.Size(362, 68);
            this.pCreateUser.TabIndex = 26;
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
            this.messagePanel.Size = new System.Drawing.Size(362, 20);
            this.messagePanel.TabIndex = 30;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(362, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // bCreateUser
            // 
            this.bCreateUser.BackColor = System.Drawing.SystemColors.Window;
            this.bCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateUser.Location = new System.Drawing.Point(153, 14);
            this.bCreateUser.Name = "bCreateUser";
            this.bCreateUser.Size = new System.Drawing.Size(182, 31);
            this.bCreateUser.TabIndex = 3;
            this.bCreateUser.Text = "Создать пользователя";
            this.bCreateUser.UseVisualStyleBackColor = false;
            this.bCreateUser.Click += new System.EventHandler(this.bCreateUser_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.lPasswordObligatory);
            this.MainPanel.Controls.Add(this.lPostObligatory);
            this.MainPanel.Controls.Add(this.lNameobligatory);
            this.MainPanel.Controls.Add(this.lPhoneNumber);
            this.MainPanel.Controls.Add(this.lPassword);
            this.MainPanel.Controls.Add(this.lPost);
            this.MainPanel.Controls.Add(this.lBirthday);
            this.MainPanel.Controls.Add(this.lName);
            this.MainPanel.Controls.Add(this.cbPost);
            this.MainPanel.Controls.Add(this.dtpBirthDay);
            this.MainPanel.Controls.Add(this.tbPhoneNumber);
            this.MainPanel.Controls.Add(this.tbPassword);
            this.MainPanel.Controls.Add(this.tbName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(362, 182);
            this.MainPanel.TabIndex = 27;
            // 
            // lPasswordObligatory
            // 
            this.lPasswordObligatory.AutoSize = true;
            this.lPasswordObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPasswordObligatory.ForeColor = System.Drawing.Color.Red;
            this.lPasswordObligatory.Location = new System.Drawing.Point(327, 114);
            this.lPasswordObligatory.Name = "lPasswordObligatory";
            this.lPasswordObligatory.Size = new System.Drawing.Size(23, 29);
            this.lPasswordObligatory.TabIndex = 29;
            this.lPasswordObligatory.Text = "*";
            // 
            // lPostObligatory
            // 
            this.lPostObligatory.AutoSize = true;
            this.lPostObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPostObligatory.ForeColor = System.Drawing.Color.Red;
            this.lPostObligatory.Location = new System.Drawing.Point(327, 78);
            this.lPostObligatory.Name = "lPostObligatory";
            this.lPostObligatory.Size = new System.Drawing.Size(23, 29);
            this.lPostObligatory.TabIndex = 28;
            this.lPostObligatory.Text = "*";
            // 
            // lNameobligatory
            // 
            this.lNameobligatory.AutoSize = true;
            this.lNameobligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameobligatory.ForeColor = System.Drawing.Color.Red;
            this.lNameobligatory.Location = new System.Drawing.Point(327, 11);
            this.lNameobligatory.Name = "lNameobligatory";
            this.lNameobligatory.Size = new System.Drawing.Size(23, 29);
            this.lNameobligatory.TabIndex = 27;
            this.lNameobligatory.Text = "*";
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(51, 150);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lPhoneNumber.TabIndex = 23;
            this.lPhoneNumber.Text = "Телефон:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(58, 116);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(48, 13);
            this.lPassword.TabIndex = 22;
            this.lPassword.Text = "Пароль:";
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
            this.tbPhoneNumber.Location = new System.Drawing.Point(116, 148);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(210, 20);
            this.tbPhoneNumber.TabIndex = 16;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(116, 114);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(210, 20);
            this.tbPassword.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(210, 20);
            this.tbName.TabIndex = 14;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pCreateUser);
            this.Controls.Add(this.labelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.pCreateUser.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Label lNewUser;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Panel pCreateUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Button bCreateUser;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lPost;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lPasswordObligatory;
        private System.Windows.Forms.Label lPostObligatory;
        private System.Windows.Forms.Label lNameobligatory;
    }
}