using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.App
{
    public partial class ClientsForm : Form
    {
        private readonly ISessionFactory sessionFactory;                           //TODO:refactor
        public ClientsForm()
        {
            InitializeComponent();
            sessionFactory = new FluentNHibernateHelper().SessionFactory;
            dgvClients.AutoGenerateColumns = true;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtAddClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }

        private void BtEditClient_Click(object sender, EventArgs e)
        {
            var client = dgvClients.SelectedRows[0].DataBoundItem as Client;
            new EditClientForm(client).ShowDialog();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            var unitOfWorck = new UnitOfWork(sessionFactory);
            unitOfWorck.BeginTransaction();
            var userRepasitory = new ClientRepository(unitOfWorck.Session);
            bsClients.DataSource = userRepasitory.SelectAll().ToList();
            
            dgvClients.Columns["Id"].Visible = false;
            dgvClients.Columns["IsArchival"].Visible = false;

            var columnHeaders = new[]                                                     //TODO:refactor
            {
                "Имя", "Email", "Штрих-код", "День рождения", "Пол", "Тип", "Долг",
                "Телефон", "Последний абонемент", "Статус", "Примечание", "Id"
            };
            for (var i = 0; i < dgvClients.Columns.Count; i++)
                dgvClients.Columns[i].HeaderText = columnHeaders[i];
        }
    }
}
