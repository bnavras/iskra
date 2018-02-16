using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class AddClientForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public AddClientForm()
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
        }

        private void btCreateClient_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введите Ваше имя!");
                return;
            }
            var newClient = new Client()
            {
                Name = tbFullName.Text,
                Barcode = tbBarcode.Text,
                ClientType = new ClientType((int)cbClientType.SelectedValue, cbClientType.SelectedText),
                Birthday = dtpBirthday.Value,
                Comment = tbChannelReceiving.Text,
                Email = tbEmail.Text,
                Gender = rbMale.Checked ? rbMale.Text : rbFemale.Text,
                Phone = tbPhoneNumber.Text
            };

            unitOfWork.BeginTransaction();
            var trainerRepository = new ClientRepository(unitOfWork.Session);
            trainerRepository.Insert(newClient);
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
            cbClientType.ValueMember = "Id";
            unitOfWork.Commit();
        }
    }
}
