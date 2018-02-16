namespace Iskra.App
{
    partial class CatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.pSellBorderUp = new System.Windows.Forms.Panel();
            this.lSellTickets = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pHelp = new System.Windows.Forms.Panel();
            this.bDelProduct = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.bDelCategory = new System.Windows.Forms.Button();
            this.btAddCategory = new System.Windows.Forms.Button();
            this.LabelPanel.SuspendLayout();
            this.pMain.SuspendLayout();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LabelPanel.Controls.Add(this.pSellBorderUp);
            this.LabelPanel.Controls.Add(this.lSellTickets);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(746, 53);
            this.LabelPanel.TabIndex = 9;
            // 
            // pSellBorderUp
            // 
            this.pSellBorderUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.pSellBorderUp.Location = new System.Drawing.Point(0, 46);
            this.pSellBorderUp.Name = "pSellBorderUp";
            this.pSellBorderUp.Size = new System.Drawing.Size(746, 7);
            this.pSellBorderUp.TabIndex = 1;
            // 
            // lSellTickets
            // 
            this.lSellTickets.AutoSize = true;
            this.lSellTickets.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lSellTickets.ForeColor = System.Drawing.Color.Gray;
            this.lSellTickets.Location = new System.Drawing.Point(12, 9);
            this.lSellTickets.Name = "lSellTickets";
            this.lSellTickets.Size = new System.Drawing.Size(96, 26);
            this.lSellTickets.TabIndex = 0;
            this.lSellTickets.Text = "Каталог";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.gbProducts);
            this.pMain.Controls.Add(this.gbCategory);
            this.pMain.Controls.Add(this.pHelp);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(746, 483);
            this.pMain.TabIndex = 11;
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.dgvProducts);
            this.gbProducts.Controls.Add(this.bDelProduct);
            this.gbProducts.Controls.Add(this.btAddProduct);
            this.gbProducts.Location = new System.Drawing.Point(331, 60);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(403, 397);
            this.gbProducts.TabIndex = 30;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Товары";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 19);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(357, 372);
            this.dgvProducts.TabIndex = 0;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.dgvCategories);
            this.gbCategory.Controls.Add(this.bDelCategory);
            this.gbCategory.Controls.Add(this.btAddCategory);
            this.gbCategory.Location = new System.Drawing.Point(4, 59);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(321, 398);
            this.gbCategory.TabIndex = 29;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Категории";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(6, 19);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(277, 373);
            this.dgvCategories.TabIndex = 0;
            // 
            // pHelp
            // 
            this.pHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.pHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pHelp.Location = new System.Drawing.Point(0, 463);
            this.pHelp.Name = "pHelp";
            this.pHelp.Size = new System.Drawing.Size(746, 20);
            this.pHelp.TabIndex = 3;
            // 
            // bDelProduct
            // 
            this.bDelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bDelProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bDelProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bDelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelProduct.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bDelProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.bDelProduct.Image = global::Iskra.App.Properties.Resources.delete;
            this.bDelProduct.Location = new System.Drawing.Point(369, 54);
            this.bDelProduct.Name = "bDelProduct";
            this.bDelProduct.Size = new System.Drawing.Size(29, 29);
            this.bDelProduct.TabIndex = 28;
            this.bDelProduct.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduct.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btAddProduct.Image")));
            this.btAddProduct.Location = new System.Drawing.Point(369, 19);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(29, 29);
            this.btAddProduct.TabIndex = 27;
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // bDelCategory
            // 
            this.bDelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bDelCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.bDelCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.bDelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelCategory.Font = new System.Drawing.Font("Arial Black", 10F);
            this.bDelCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.bDelCategory.Image = global::Iskra.App.Properties.Resources.delete;
            this.bDelCategory.Location = new System.Drawing.Point(286, 54);
            this.bDelCategory.Name = "bDelCategory";
            this.bDelCategory.Size = new System.Drawing.Size(29, 29);
            this.bDelCategory.TabIndex = 28;
            this.bDelCategory.UseVisualStyleBackColor = true;
            // 
            // btAddCategory
            // 
            this.btAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCategory.Font = new System.Drawing.Font("Arial Black", 10F);
            this.btAddCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.btAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btAddCategory.Image")));
            this.btAddCategory.Location = new System.Drawing.Point(286, 19);
            this.btAddCategory.Name = "btAddCategory";
            this.btAddCategory.Size = new System.Drawing.Size(29, 29);
            this.btAddCategory.TabIndex = 27;
            this.btAddCategory.UseVisualStyleBackColor = true;
            this.btAddCategory.Click += new System.EventHandler(this.btAddCategory_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 483);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CatalogForm";
            this.Text = "Искра | Каталог товаров";
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.gbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel pSellBorderUp;
        private System.Windows.Forms.Label lSellTickets;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button bDelCategory;
        private System.Windows.Forms.Button btAddCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button bDelProduct;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Panel pHelp;
    }
}