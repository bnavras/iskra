using System;
using System.Windows.Forms;
using Iskra.App.Main_window.Button_list.Subscription;

namespace Iskra.App
{
    public partial class AddNewTicket : Form
    {
        public AddNewTicket()
        {
            InitializeComponent();
        }

        private void BtAddProgram_Click(object sender, EventArgs e)
        {
            new AddProgramForm().ShowDialog();
        }
    }
}
