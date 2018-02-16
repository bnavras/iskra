namespace Iskra.App
{
    partial class AddClassForm
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
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lAddClass = new System.Windows.Forms.Label();
            this.pmessageBorder = new System.Windows.Forms.Panel();
            this.pmessage = new System.Windows.Forms.Panel();
            this.pSave = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lClass = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lTrener = new System.Windows.Forms.Label();
            this.lpayment = new System.Windows.Forms.Label();
            this.lPayMetod = new System.Windows.Forms.Label();
            this.lclientFlag = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LabelPanel.SuspendLayout();
            this.pSave.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Controls.Add(this.lAddClass);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(357, 47);
            this.LabelPanel.TabIndex = 3;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 39);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(357, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lAddClass
            // 
            this.lAddClass.AutoSize = true;
            this.lAddClass.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddClass.ForeColor = System.Drawing.Color.Gray;
            this.lAddClass.Location = new System.Drawing.Point(12, 9);
            this.lAddClass.Name = "lAddClass";
            this.lAddClass.Size = new System.Drawing.Size(214, 24);
            this.lAddClass.TabIndex = 0;
            this.lAddClass.Text = "Добавление занятия";
            // 
            // pmessageBorder
            // 
            this.pmessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pmessageBorder.Location = new System.Drawing.Point(0, 52);
            this.pmessageBorder.Name = "pmessageBorder";
            this.pmessageBorder.Size = new System.Drawing.Size(357, 2);
            this.pmessageBorder.TabIndex = 3;
            // 
            // pmessage
            // 
            this.pmessage.BackColor = System.Drawing.SystemColors.Menu;
            this.pmessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pmessage.Location = new System.Drawing.Point(0, 54);
            this.pmessage.Name = "pmessage";
            this.pmessage.Size = new System.Drawing.Size(357, 20);
            this.pmessage.TabIndex = 3;
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.SystemColors.Info;
            this.pSave.Controls.Add(this.pmessageBorder);
            this.pSave.Controls.Add(this.bSave);
            this.pSave.Controls.Add(this.pmessage);
            this.pSave.Controls.Add(this.pSellBorderDown);
            this.pSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSave.Location = new System.Drawing.Point(0, 217);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(357, 74);
            this.pSave.TabIndex = 4;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.Window;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSave.Location = new System.Drawing.Point(161, 14);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(184, 33);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, -2);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(357, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lclientFlag);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.lPayMetod);
            this.panel1.Controls.Add(this.lpayment);
            this.panel1.Controls.Add(this.lTrener);
            this.panel1.Controls.Add(this.lTime);
            this.panel1.Controls.Add(this.lClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 170);
            this.panel1.TabIndex = 5;
            // 
            // lClass
            // 
            this.lClass.AutoSize = true;
            this.lClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClass.Location = new System.Drawing.Point(24, 20);
            this.lClass.Name = "lClass";
            this.lClass.Size = new System.Drawing.Size(60, 15);
            this.lClass.TabIndex = 0;
            this.lClass.Text = "Занятие:";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.Location = new System.Drawing.Point(36, 45);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(48, 15);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "Время:";
            // 
            // lTrener
            // 
            this.lTrener.AutoSize = true;
            this.lTrener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTrener.Location = new System.Drawing.Point(32, 75);
            this.lTrener.Name = "lTrener";
            this.lTrener.Size = new System.Drawing.Size(52, 15);
            this.lTrener.TabIndex = 2;
            this.lTrener.Text = "Тренер:";
            // 
            // lpayment
            // 
            this.lpayment.AutoSize = true;
            this.lpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lpayment.Location = new System.Drawing.Point(23, 102);
            this.lpayment.Name = "lpayment";
            this.lpayment.Size = new System.Drawing.Size(61, 15);
            this.lpayment.TabIndex = 3;
            this.lpayment.Text = "Доплата:";
            // 
            // lPayMetod
            // 
            this.lPayMetod.AutoSize = true;
            this.lPayMetod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPayMetod.Location = new System.Drawing.Point(6, 131);
            this.lPayMetod.Name = "lPayMetod";
            this.lPayMetod.Size = new System.Drawing.Size(78, 15);
            this.lPayMetod.TabIndex = 4;
            this.lPayMetod.Text = "Тип оплаты:";
            // 
            // lclientFlag
            // 
            this.lclientFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lclientFlag.ForeColor = System.Drawing.Color.Red;
            this.lclientFlag.Location = new System.Drawing.Point(322, 16);
            this.lclientFlag.Name = "lclientFlag";
            this.lclientFlag.Size = new System.Drawing.Size(23, 23);
            this.lclientFlag.TabIndex = 21;
            this.lclientFlag.Text = "*";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(90, 19);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(224, 21);
            this.cbClient.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(322, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "*";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(90, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(90, 131);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 21);
            this.comboBox3.TabIndex = 26;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(90, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(224, 20);
            this.numericUpDown1.TabIndex = 28;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.pSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClassForm";
            this.Text = "Искра | Занятие";
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.pSave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lAddClass;
        private System.Windows.Forms.Panel pmessageBorder;
        private System.Windows.Forms.Panel pmessage;
        private System.Windows.Forms.Panel pSave;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lPayMetod;
        private System.Windows.Forms.Label lpayment;
        private System.Windows.Forms.Label lTrener;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lClass;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lclientFlag;
        private System.Windows.Forms.ComboBox cbClient;
    }
}