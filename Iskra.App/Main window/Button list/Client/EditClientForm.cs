using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class EditClientForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        private readonly Client client;
        public EditClientForm(Client client)
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
            this.client = client;
        }

        private void btSaveClient_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введите Ваше имя!");
                return;
            }

            client.Name = tbFullName.Text;
            client.Barcode = tbBarcode.Text;
            client.ClientType = cbClientType.SelectedValue as ClientType;
            client.Birthday = dtpBirthday.Value;
            client.Comment = tbChannelReceiving.Text;
            client.Email = tbEmail.Text;
            client.Gender = rbMale.Checked ? rbMale.Text : rbFemale.Text;
            client.Phone = tbPhoneNumber.Text;

            unitOfWork.BeginTransaction();
            var trainerRepository = new ClientRepository(unitOfWork.Session);
            trainerRepository.Update(client);
            unitOfWork.Commit();

            Close();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var clientTypeRepository = new ClientTypeRepository(unitOfWork.Session)
                .SelectAll()
                .ToList();
            cbClientType.DataSource = clientTypeRepository;
            cbClientType.DisplayMember = "Title";
            unitOfWork.Commit();

            cbClientType.SelectedIndex = cbClientType.FindString(client.ClientType.Title);
            tbFullName.Text = client.Name;
            tbBarcode.Text = client.Barcode;
            tbChannelReceiving.Text = client.Comment;
            tbEmail.Text = client.Email;
            tbPhoneNumber.Text = client.Phone;
            if (client.Gender == "Мужской") rbMale.Checked = true;
            rbFemale.Checked = !rbMale.Checked;
        }
    }
}
