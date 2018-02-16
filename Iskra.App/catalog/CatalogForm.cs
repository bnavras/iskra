using System;
using System.Windows.Forms;

namespace Iskra.App
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            new AddCategoryForm().ShowDialog();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }
    }
}
