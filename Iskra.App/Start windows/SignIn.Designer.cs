namespace Iskra.App
{
    partial class SignIn
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
            this.btSignIn = new System.Windows.Forms.Button();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pSell = new System.Windows.Forms.Panel();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ldiscountFlag = new System.Windows.Forms.Label();
            this.luser = new System.Windows.Forms.Label();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lpasswird = new System.Windows.Forms.Label();
            this.LabelPanel.SuspendLayout();
            this.pSell.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.SystemColors.Window;
            this.btSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSignIn.Location = new System.Drawing.Point(193, 14);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(164, 31);
            this.btSignIn.TabIndex = 3;
            this.btSignIn.Text = "Войти";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(397, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(368, 53);
            this.LabelPanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 2);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 20);
            this.panel2.TabIndex = 30;
            // 
            // pSell
            // 
            this.pSell.BackColor = System.Drawing.SystemColors.Info;
            this.pSell.Controls.Add(this.panel3);
            this.pSell.Controls.Add(this.panel2);
            this.pSell.Controls.Add(this.pSellBorderDown);
            this.pSell.Controls.Add(this.btSignIn);
            this.pSell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSell.Location = new System.Drawing.Point(0, 154);
            this.pSell.Name = "pSell";
            this.pSell.Size = new System.Drawing.Size(368, 68);
            this.pSell.TabIndex = 16;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, 1);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(397, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ldiscountFlag);
            this.panel1.Controls.Add(this.luser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 101);
            this.panel1.TabIndex = 17;
            // 
            // ldiscountFlag
            // 
            this.ldiscountFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ldiscountFlag.ForeColor = System.Drawing.Color.Red;
            this.ldiscountFlag.Location = new System.Drawing.Point(335, 53);
            this.ldiscountFlag.Name = "ldiscountFlag";
            this.ldiscountFlag.Size = new System.Drawing.Size(16, 23);
            this.ldiscountFlag.TabIndex = 22;
            this.ldiscountFlag.Text = "*";
            // 
            // luser
            // 
            this.luser.BackColor = System.Drawing.SystemColors.Window;
            this.luser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.luser.Location = new System.Drawing.Point(21, 22);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(106, 21);
            this.luser.TabIndex = 19;
            this.luser.Text = "Пользователь:";
            // 
            // cbuser
            // 
            this.cbuser.AllowDrop = true;
            this.cbuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(133, 75);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(202, 21);
            this.cbuser.TabIndex = 1;
            this.cbuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbuser_KeyDown);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpassword.Location = new System.Drawing.Point(133, 108);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(202, 23);
            this.tbpassword.TabIndex = 2;
            this.tbpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyDown);
            // 
            // lpasswird
            // 
            this.lpasswird.AutoSize = true;
            this.lpasswird.BackColor = System.Drawing.SystemColors.Window;
            this.lpasswird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lpasswird.Location = new System.Drawing.Point(67, 108);
            this.lpasswird.Name = "lpasswird";
            this.lpasswird.Size = new System.Drawing.Size(60, 16);
            this.lpasswird.TabIndex = 21;
            this.lpasswird.Text = "Пароль:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 222);
            this.Controls.Add(this.cbuser);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lpasswird);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.pSell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignIn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Искра";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.LabelPanel.ResumeLayout(false);
            this.pSell.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pSell;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lpasswird;
        private System.Windows.Forms.Label ldiscountFlag;
    }
}