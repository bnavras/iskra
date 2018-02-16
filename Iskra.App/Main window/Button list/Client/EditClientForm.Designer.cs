namespace Iskra.App
{
    partial class EditClientForm
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
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.tbChannelReceiving = new System.Windows.Forms.TextBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbEditClient = new System.Windows.Forms.Label();
            this.lСhannelReceiving = new System.Windows.Forms.Label();
            this.lNameobligatory = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.lClientType = new System.Windows.Forms.Label();
            this.lBirthday = new System.Windows.Forms.Label();
            this.lSex = new System.Windows.Forms.Label();
            this.lBarcode = new System.Windows.Forms.Label();
            this.lFullName = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.pMessageBorder = new System.Windows.Forms.Panel();
            this.btSaveClient = new System.Windows.Forms.Button();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.cbClientType);
            this.MainPanel.Controls.Add(this.tbChannelReceiving);
            this.MainPanel.Controls.Add(this.labelPanel);
            this.MainPanel.Controls.Add(this.lСhannelReceiving);
            this.MainPanel.Controls.Add(this.lNameobligatory);
            this.MainPanel.Controls.Add(this.rbFemale);
            this.MainPanel.Controls.Add(this.rbMale);
            this.MainPanel.Controls.Add(this.tbEmail);
            this.MainPanel.Controls.Add(this.dtpBirthday);
            this.MainPanel.Controls.Add(this.tbPhoneNumber);
            this.MainPanel.Controls.Add(this.tbBarcode);
            this.MainPanel.Controls.Add(this.tbFullName);
            this.MainPanel.Controls.Add(this.lEmail);
            this.MainPanel.Controls.Add(this.lPhoneNumber);
            this.MainPanel.Controls.Add(this.lClientType);
            this.MainPanel.Controls.Add(this.lBirthday);
            this.MainPanel.Controls.Add(this.lSex);
            this.MainPanel.Controls.Add(this.lBarcode);
            this.MainPanel.Controls.Add(this.lFullName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(444, 471);
            this.MainPanel.TabIndex = 1;
            // 
            // cbClientType
            // 
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Location = new System.Drawing.Point(117, 184);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(221, 21);
            this.cbClientType.TabIndex = 68;
            // 
            // tbChannelReceiving
            // 
            this.tbChannelReceiving.Location = new System.Drawing.Point(17, 288);
            this.tbChannelReceiving.Multiline = true;
            this.tbChannelReceiving.Name = "tbChannelReceiving";
            this.tbChannelReceiving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChannelReceiving.Size = new System.Drawing.Size(383, 98);
            this.tbChannelReceiving.TabIndex = 67;
            // 
            // labelPanel
            // 
            this.labelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbEditClient);
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(444, 53);
            this.labelPanel.TabIndex = 61;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 45);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(444, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbEditClient
            // 
            this.lbEditClient.AutoSize = true;
            this.lbEditClient.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbEditClient.ForeColor = System.Drawing.Color.Gray;
            this.lbEditClient.Location = new System.Drawing.Point(3, 9);
            this.lbEditClient.Name = "lbEditClient";
            this.lbEditClient.Size = new System.Drawing.Size(281, 26);
            this.lbEditClient.TabIndex = 0;
            this.lbEditClient.Text = "Редактирование клиента";
            // 
            // lСhannelReceiving
            // 
            this.lСhannelReceiving.AutoSize = true;
            this.lСhannelReceiving.Location = new System.Drawing.Point(14, 271);
            this.lСhannelReceiving.Name = "lСhannelReceiving";
            this.lСhannelReceiving.Size = new System.Drawing.Size(171, 13);
            this.lСhannelReceiving.TabIndex = 34;
            this.lСhannelReceiving.Text = "Откуда узнали о фитнес центре:";
            // 
            // lNameobligatory
            // 
            this.lNameobligatory.AutoSize = true;
            this.lNameobligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameobligatory.ForeColor = System.Drawing.Color.Red;
            this.lNameobligatory.Location = new System.Drawing.Point(406, 60);
            this.lNameobligatory.Name = "lNameobligatory";
            this.lNameobligatory.Size = new System.Drawing.Size(23, 29);
            this.lNameobligatory.TabIndex = 26;
            this.lNameobligatory.Text = "*";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(228, 129);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 17);
            this.rbFemale.TabIndex = 25;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(117, 129);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 17);
            this.rbMale.TabIndex = 24;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(117, 239);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(221, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(117, 156);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(221, 20);
            this.dtpBirthday.TabIndex = 19;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(117, 213);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(221, 20);
            this.tbPhoneNumber.TabIndex = 16;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(117, 94);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(283, 20);
            this.tbBarcode.TabIndex = 14;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(117, 63);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(283, 20);
            this.tbFullName.TabIndex = 10;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(67, 241);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(34, 13);
            this.lEmail.TabIndex = 9;
            this.lEmail.Text = "email:";
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(46, 216);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lPhoneNumber.TabIndex = 8;
            this.lPhoneNumber.Text = "Телефон:";
            // 
            // lClientType
            // 
            this.lClientType.AutoSize = true;
            this.lClientType.Location = new System.Drawing.Point(72, 193);
            this.lClientType.Name = "lClientType";
            this.lClientType.Size = new System.Drawing.Size(29, 13);
            this.lClientType.TabIndex = 7;
            this.lClientType.Text = "Тип:";
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Location = new System.Drawing.Point(12, 158);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(89, 13);
            this.lBirthday.TabIndex = 6;
            this.lBirthday.Text = "Дата рождения:";
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Location = new System.Drawing.Point(71, 129);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(30, 13);
            this.lSex.TabIndex = 5;
            this.lSex.Text = "Пол:";
            // 
            // lBarcode
            // 
            this.lBarcode.AutoSize = true;
            this.lBarcode.Location = new System.Drawing.Point(39, 94);
            this.lBarcode.Name = "lBarcode";
            this.lBarcode.Size = new System.Drawing.Size(62, 13);
            this.lBarcode.TabIndex = 2;
            this.lBarcode.Text = "Штрих-код:";
            // 
            // lFullName
            // 
            this.lFullName.AutoSize = true;
            this.lFullName.Location = new System.Drawing.Point(36, 63);
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(65, 13);
            this.lFullName.TabIndex = 0;
            this.lFullName.Text = "Имя(ФИО):";
            // 
            // savePanel
            // 
            this.savePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePanel.BackColor = System.Drawing.SystemColors.Info;
            this.savePanel.Controls.Add(this.pMessageBorder);
            this.savePanel.Controls.Add(this.btSaveClient);
            this.savePanel.Controls.Add(this.messegePanel);
            this.savePanel.Controls.Add(this.pSellBorderDown);
            this.savePanel.Location = new System.Drawing.Point(0, 402);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(444, 69);
            this.savePanel.TabIndex = 61;
            // 
            // pMessageBorder
            // 
            this.pMessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pMessageBorder.Location = new System.Drawing.Point(0, 50);
            this.pMessageBorder.Name = "pMessageBorder";
            this.pMessageBorder.Size = new System.Drawing.Size(444, 2);
            this.pMessageBorder.TabIndex = 3;
            // 
            // btSaveClient
            // 
            this.btSaveClient.BackColor = System.Drawing.SystemColors.Window;
            this.btSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSaveClient.Location = new System.Drawing.Point(233, 14);
            this.btSaveClient.Name = "btSaveClient";
            this.btSaveClient.Size = new System.Drawing.Size(196, 28);
            this.btSaveClient.TabIndex = 4;
            this.btSaveClient.Text = "Сохранить";
            this.btSaveClient.UseVisualStyleBackColor = false;
            this.btSaveClient.Click += new System.EventHandler(this.btSaveClient_Click);
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 49);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(444, 20);
            this.messegePanel.TabIndex = 3;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(444, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 471);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditClientForm";
            this.Text = "Искра | Клиент";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lСhannelReceiving;
        private System.Windows.Forms.Label lNameobligatory;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.Label lClientType;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.Label lBarcode;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbEditClient;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Panel pMessageBorder;
        private System.Windows.Forms.Button btSaveClient;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.TextBox tbChannelReceiving;
        private System.Windows.Forms.ComboBox cbClientType;
    }
}