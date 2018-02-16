using System;
using System.Windows.Forms;

namespace Iskra.App
{
    public partial class BarForm : Form
    {
        public BarForm()
        {
            InitializeComponent();
        }
        private void BtAddClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }
    }
}
