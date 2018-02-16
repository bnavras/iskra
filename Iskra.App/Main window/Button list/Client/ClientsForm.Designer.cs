namespace Iskra.App
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.bsClients = new System.Windows.Forms.BindingSource(this.components);
            this.bSearch = new System.Windows.Forms.Button();
            this.btEditClient = new System.Windows.Forms.Button();
            this.btAddClient = new System.Windows.Forms.Button();
            this.btDelClient = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lbClients = new System.Windows.Forms.Label();
            this.messegePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dgvClients);
            this.panel2.Controls.Add(this.bSearch);
            this.panel2.Controls.Add(this.btEditClient);
            this.panel2.Controls.Add(this.btAddClient);
            this.panel2.Controls.Add(this.btDelClient);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 501);
            this.panel2.TabIndex = 1;
            // 
            // dgvClients
            // 
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.DataSource = this.bsClients;
            this.dgvClients.Location = new System.Drawing.Point(10, 92);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(428, 381);
            this.dgvClients.TabIndex = 53;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.bSearch.Image = global::Iskra.App.Properties.Resources.search;
            this.bSearch.Location = new System.Drawing.Point(445, 52);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(29, 29);
            this.bSearch.TabIndex = 52;
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // btEditClient
            // 
            this.btEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditClient.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btEditClient.ForeColor = System.Drawing.SystemColors.Window;
            this.btEditClient.Image = global::Iskra.App.Properties.Resources.edit;
            this.btEditClient.Location = new System.Drawing.Point(444, 127);
            this.btEditClient.Name = "btEditClient";
            this.btEditClient.Size = new System.Drawing.Size(29, 29);
            this.btEditClient.TabIndex = 51;
            this.btEditClient.UseVisualStyleBackColor = true;
            this.btEditClient.Click += new System.EventHandler(this.BtEditClient_Click);
            // 
            // btAddClient
            // 
            this.btAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddClient.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddClient.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btAddClient.Image")));
            this.btAddClient.Location = new System.Drawing.Point(444, 92);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(29, 29);
            this.btAddClient.TabIndex = 49;
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.BtAddClient_Click);
            // 
            // btDelClient
            // 
            this.btDelClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btDelClient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btDelClient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btDelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelClient.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btDelClient.ForeColor = System.Drawing.SystemColors.Window;
            this.btDelClient.Image = global::Iskra.App.Properties.Resources.delete;
            this.btDelClient.Location = new System.Drawing.Point(444, 162);
            this.btDelClient.Name = "btDelClient";
            this.btDelClient.Size = new System.Drawing.Size(29, 29);
            this.btDelClient.TabIndex = 50;
            this.btDelClient.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(10, 60);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(428, 20);
            this.tbSearch.TabIndex = 7;
            // 
            // labelPanel
            // 
            this.labelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.labelPanel.Controls.Add(this.pSellBorderUp);
            this.labelPanel.Controls.Add(this.lbClients);
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(488, 49);
            this.labelPanel.TabIndex = 5;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 44);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(512, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lbClients
            // 
            this.lbClients.AutoSize = true;
            this.lbClients.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbClients.ForeColor = System.Drawing.Color.Gray;
            this.lbClients.Location = new System.Drawing.Point(3, 9);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(106, 26);
            this.lbClients.TabIndex = 0;
            this.lbClients.Text = "Клиенты";
            // 
            // messegePanel
            // 
            this.messegePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messegePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.messegePanel.Location = new System.Drawing.Point(0, 481);
            this.messegePanel.Name = "messegePanel";
            this.messegePanel.Size = new System.Drawing.Size(488, 20);
            this.messegePanel.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(-1, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 2);
            this.panel3.TabIndex = 51;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 501);
            this.Controls.Add(this.messegePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.panel2);
            this.Name = "ClientsForm";
            this.Text = "Искра | Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClients)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel messegePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEditClient;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Button btDelClient;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.BindingSource bsClients;
    }
}