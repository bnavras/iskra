namespace Iskra.App
{
    partial class AddNewTrainerForm
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
            this.savePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bAddTrainer = new System.Windows.Forms.Button();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lbObligatory = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbNewTrainer = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNotice = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // savePanel
            // 
            this.savePanel.BackColor = System.Drawing.SystemColors.Info;
            this.savePanel.Controls.Add(this.panel3);
            this.savePanel.Controls.Add(this.bAddTrainer);
            this.savePanel.Controls.Add(this.messegePanel);
            this.savePanel.Controls.Add(this.pSellBorderDown);
            this.savePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savePanel.Location = new System.Drawing.Point(0, 284);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(339, 69);
            this.savePanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 2);
            this.panel3.TabIndex = 3;
            // 
            // bAddTrainer
            // 
            this.bAddTrainer.BackColor = System.Drawing.SystemColors.Window;
            this.bAddTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAddTrainer.Location = new System.Drawing.Point(159, 15);
            this.bAddTrainer.Name = "bAddTrainer";
            this.bAddTrainer.Size = new System.Drawing.Size(172, 28);
            this.bAddTrainer.TabIndex = 4;
            this.bAddTrainer.Text = "Добавить";
            this.bAddTrainer.UseVisualStyleBackColor = false;
            this.bAddTrainer.Click += new System.EventHandler(this.bAddTrainer_Click);
            // 
            // messegePanel
            // 
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messegePanel.Location = new System.Drawing.Point(0, 49);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(339, 20);
            this.messegePanel.TabIndex = 3;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(339, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.lbObligatory);
            this.MainPanel.Controls.Add(this.labelPanel);
            this.MainPanel.Controls.Add(this.lbNotice);
            this.MainPanel.Controls.Add(this.lbPhoneNumber);
            this.MainPanel.Controls.Add(this.lbBirthday);
            this.MainPanel.Controls.Add(this.lbName);
            this.MainPanel.Controls.Add(this.tbNotice);
            this.MainPanel.Controls.Add(this.tbPhoneNumber);
            this.MainPanel.Controls.Add(this.dtpBirthday);
            this.MainPanel.Controls.Add(this.tbName);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(339, 353);
            this.MainPanel.TabIndex = 13;
            // 
            // lbObligatory
            // 
            this.lbObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbObligatory.ForeColor = System.Drawing.Color.Red;
            this.lbObligatory.Location = new System.Drawing.Point(315, 72);
            this.lbObligatory.Name = "lbObligatory";
            this.lbObligatory.Size = new System.Drawing.Size(16, 23);
            this.lbObligatory.TabIndex = 60;
            this.lbObligatory.Text = "*";
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbNewTrainer);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(339, 53);
            this.labelPanel.TabIndex = 59;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 45);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(339, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbNewTrainer
            // 
            this.lbNewTrainer.AutoSize = true;
            this.lbNewTrainer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbNewTrainer.ForeColor = System.Drawing.Color.Gray;
            this.lbNewTrainer.Location = new System.Drawing.Point(3, 9);
            this.lbNewTrainer.Name = "lbNewTrainer";
            this.lbNewTrainer.Size = new System.Drawing.Size(166, 26);
            this.lbNewTrainer.TabIndex = 0;
            this.lbNewTrainer.Text = "Новый тренер";
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Location = new System.Drawing.Point(11, 179);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(73, 13);
            this.lbNotice.TabIndex = 58;
            this.lbNotice.Text = "Примечание:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(47, 147);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lbPhoneNumber.TabIndex = 57;
            this.lbPhoneNumber.Text = "Телефон:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(17, 114);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(89, 13);
            this.lbBirthday.TabIndex = 56;
            this.lbBirthday.Text = "Дата рождения:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(65, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 13);
            this.lbName.TabIndex = 55;
            this.lbName.Text = "ФИО:";
            // 
            // tbNotice
            // 
            this.tbNotice.Location = new System.Drawing.Point(14, 196);
            this.tbNotice.Multiline = true;
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotice.Size = new System.Drawing.Size(300, 82);
            this.tbNotice.TabIndex = 54;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(108, 144);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(206, 20);
            this.tbPhoneNumber.TabIndex = 53;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Checked = false;
            this.dtpBirthday.Location = new System.Drawing.Point(108, 110);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.ShowCheckBox = true;
            this.dtpBirthday.Size = new System.Drawing.Size(206, 20);
            this.dtpBirthday.TabIndex = 52;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(108, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 20);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(-1, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 2);
            this.panel2.TabIndex = 49;
            // 
            // AddNewTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 353);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewTrainerForm";
            this.Text = "Искра | Новый тренер";
            this.savePanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bAddTrainer;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNotice;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbNewTrainer;
        private System.Windows.Forms.Label lbObligatory;
    }
}