using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.App
{
    public partial class TicketsForm : Form
    {
        private readonly ISessionFactory sessionFactory;                              //TODO:refactor
        public TicketsForm()
        {
            InitializeComponent();
            sessionFactory = new FluentNHibernateHelper().SessionFactory;
            dgvTickets.AutoGenerateColumns = true;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtAddSubscription_Click(object sender, EventArgs e)
        {
            new AddNewTicket().ShowDialog();
        }

        private void BtEditSubscription_Click(object sender, EventArgs e)
        {
            new EditTicketTemplateForm().ShowDialog();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            var unitOfWorck = new UnitOfWork(sessionFactory);
            unitOfWorck.BeginTransaction();
            var userRepasitory = new TicketRepository(unitOfWorck.Session);
            bsTickets.DataSource = userRepasitory.SelectAll().ToList();
            //TODO:refactor
            dgvTickets.Columns["Id"].Visible = false;
            dgvTickets.Columns["IsArchival"].Visible = false;
            //TODO:refactor
            var columnHeaders = new[]
            {
                "Тип", "Клиент", "Скидка", "Администратор", "Осталось визитов",
                "Стоимость", "К оплате", "Cрок действия", "Статус", "Заморозка", "Id"
            };
            for (var i = 0; i < dgvTickets.Columns.Count; i++)
                dgvTickets.Columns[i].HeaderText = columnHeaders[i];
        }
    }
}
