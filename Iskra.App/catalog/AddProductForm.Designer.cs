﻿namespace Iskra.App
{
    partial class AddProductForm
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.nUDsell = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lPayMetod = new System.Windows.Forms.Label();
            this.lpayment = new System.Windows.Forms.Label();
            this.lProductName = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.pSellBorderDown = new System.Windows.Forms.Panel();
            this.pSave = new System.Windows.Forms.Panel();
            this.pmessageBorder = new System.Windows.Forms.Panel();
            this.pmessage = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lAddProduct = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.LabelPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsell)).BeginInit();
            this.pSave.SuspendLayout();
            this.pMain.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(110, 82);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(224, 20);
            this.tbCode.TabIndex = 29;
            // 
            // nUDsell
            // 
            this.nUDsell.Location = new System.Drawing.Point(110, 55);
            this.nUDsell.Name = "nUDsell";
            this.nUDsell.Size = new System.Drawing.Size(224, 20);
            this.nUDsell.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(342, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "*";
            // 
            // lPayMetod
            // 
            this.lPayMetod.AutoSize = true;
            this.lPayMetod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPayMetod.Location = new System.Drawing.Point(26, 81);
            this.lPayMetod.Name = "lPayMetod";
            this.lPayMetod.Size = new System.Drawing.Size(72, 15);
            this.lPayMetod.TabIndex = 4;
            this.lPayMetod.Text = "Штрих-код:";
            // 
            // lpayment
            // 
            this.lpayment.AutoSize = true;
            this.lpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lpayment.Location = new System.Drawing.Point(58, 55);
            this.lpayment.Name = "lpayment";
            this.lpayment.Size = new System.Drawing.Size(40, 15);
            this.lpayment.TabIndex = 3;
            this.lpayment.Text = "Цена:";
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProductName.Location = new System.Drawing.Point(31, 25);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(67, 15);
            this.lProductName.TabIndex = 2;
            this.lProductName.Text = "Название:";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.Window;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bSave.Location = new System.Drawing.Point(195, 13);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(190, 33);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Добавить";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // pSellBorderDown
            // 
            this.pSellBorderDown.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderDown.Location = new System.Drawing.Point(0, -2);
            this.pSellBorderDown.Name = "pSellBorderDown";
            this.pSellBorderDown.Size = new System.Drawing.Size(397, 7);
            this.pSellBorderDown.TabIndex = 2;
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.SystemColors.Info;
            this.pSave.Controls.Add(this.pmessageBorder);
            this.pSave.Controls.Add(this.bSave);
            this.pSave.Controls.Add(this.pmessage);
            this.pSave.Controls.Add(this.pSellBorderDown);
            this.pSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSave.Location = new System.Drawing.Point(0, 169);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(397, 74);
            this.pSave.TabIndex = 10;
            // 
            // pmessageBorder
            // 
            this.pmessageBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pmessageBorder.Location = new System.Drawing.Point(0, 52);
            this.pmessageBorder.Name = "pmessageBorder";
            this.pmessageBorder.Size = new System.Drawing.Size(397, 2);
            this.pmessageBorder.TabIndex = 3;
            // 
            // pmessage
            // 
            this.pmessage.BackColor = System.Drawing.SystemColors.Menu;
            this.pmessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pmessage.Location = new System.Drawing.Point(0, 54);
            this.pmessage.Name = "pmessage";
            this.pmessage.Size = new System.Drawing.Size(397, 20);
            this.pmessage.TabIndex = 3;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 39);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(397, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lAddProduct
            // 
            this.lAddProduct.AutoSize = true;
            this.lAddProduct.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddProduct.ForeColor = System.Drawing.Color.Gray;
            this.lAddProduct.Location = new System.Drawing.Point(12, 9);
            this.lAddProduct.Name = "lAddProduct";
            this.lAddProduct.Size = new System.Drawing.Size(166, 24);
            this.lAddProduct.TabIndex = 0;
            this.lAddProduct.Text = "Добавить товар";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.tbProductName);
            this.pMain.Controls.Add(this.tbCode);
            this.pMain.Controls.Add(this.nUDsell);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.lPayMetod);
            this.pMain.Controls.Add(this.lpayment);
            this.pMain.Controls.Add(this.lProductName);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 47);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(397, 196);
            this.pMain.TabIndex = 11;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(110, 24);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(224, 20);
            this.tbProductName.TabIndex = 30;
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Controls.Add(this.lAddProduct);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(397, 47);
            this.LabelPanel.TabIndex = 9;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 243);
            this.Controls.Add(this.pSave);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.LabelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductForm";
            this.Text = "Искра | Добавить товар";
            ((System.ComponentModel.ISupportInitialize)(this.nUDsell)).EndInit();
            this.pSave.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.NumericUpDown nUDsell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lPayMetod;
        private System.Windows.Forms.Label lpayment;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel pSellBorderDown;
        private System.Windows.Forms.Panel pSave;
        private System.Windows.Forms.Panel pmessageBorder;
        private System.Windows.Forms.Panel pmessage;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lAddProduct;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.TextBox tbProductName;
    }
}