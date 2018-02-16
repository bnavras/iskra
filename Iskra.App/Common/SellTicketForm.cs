using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class SellTicketForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public SellTicketForm()
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
        }

        private void BtAddClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }
        private void LoadClients()
        {
            unitOfWork.BeginTransaction();
            var clientRepository = new ClientRepository(unitOfWork.Session);
            var clients = clientRepository.SelectAll().ToList();
            cbClient.DataSource = clients;
            cbClient.DisplayMember = "Name";
            unitOfWork.Commit();
        }

        private void LoadTickets()
        {
            unitOfWork.BeginTransaction();
            var ticketsRepository = new TicketTypeRepository(unitOfWork.Session);
            var tickets = ticketsRepository.SelectAll().ToList();
            cbTicket.DataSource = tickets;
            cbTicket.DisplayMember = "Title";
            unitOfWork.Commit();
        }
        private void LoadDiscounts()
        {
            unitOfWork.BeginTransaction();
            var discountsRepository = new DiscountRepository(unitOfWork.Session);
            var discounts = discountsRepository.SelectAll().ToList();
            cbDiscount.DataSource = discounts;
            unitOfWork.Commit();
        }

        private void SellTicketForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadDiscounts();
            LoadTickets();
        }

        private void cbClient_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClient = cbClient.SelectedValue as Client;
            tbCode.Text = selectedClient?.Barcode;
            tbCredit.Text = selectedClient?.Credit.ToString();
        }

        private void cbTicket_SelectedValueChanged(object sender, EventArgs e)
        {
            cbDiscount_SelectedValueChanged(null, null);
        }

        private void cbDiscount_SelectedValueChanged(object sender, EventArgs e)
        {
            var ticketType = cbTicket.SelectedValue as TicketType;
            var discount = cbDiscount.SelectedValue as Discount;
            tbPayment.Text = ticketType?.CalculateFullCost(discount?.Percent ?? 0).ToString();
            tbPaid_TextChanged(null, null);
        }

        private void tbPaid_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(tbPaid.Text, out double paid)) paid = 0;
            if (!double.TryParse(tbCredit.Text, out double credit)) credit = 0;
            if (!double.TryParse(tbPayment.Text, out double payment)) payment = 0;

            tbRest.Text = (credit + payment - paid).ToString();
        }

        private void btTicketHelp_Click(object sender, EventArgs e)
        {
            var ticket = cbTicket.SelectedValue as TicketType;
            if (ticket == null) return;
            MessageBox.Show($"Абонемент: {ticket.Title}\n" +
                            $"Количество занятий: {ticket.TrainingCount}\n" +
                            $"Номинал: {ticket.Nominal}\n");
        }

        private Ticket GetSelectedTicket()
        {
            var ticketType = cbTicket.SelectedValue as TicketType;
            var discount = cbDiscount.SelectedValue as Discount;
            var ticket = new Ticket()
            {
                Client = cbClient.SelectedValue as Client,
                Duty = MainForm.Duty,
                TicketType = ticketType,
                Discount = discount,
                ExpirationTime = DateTime.Now.AddMonths(2),
                SellTime = DateTime.Now,
                TotalCost = ticketType?.CalculateFullCost(discount?.Percent ?? 0) ?? 0,
                VisitQuantity = ticketType?.TrainingCount ?? 0
            };
            ticket.Client.Credit = double.Parse(tbRest.Text);
            return ticket;
        }
        private void btSellTicket_Click(object sender, EventArgs e)
        {
            var ticket = GetSelectedTicket();
            if (ticket.Duty == null)
            {
                MessageBox.Show("Откройте смену!");
                return;

            }
            if (ticket.Client == null || ticket.TicketType == null || ticket.Discount == null)
            {
               MessageBox.Show("Заполните все поля!");
               return;
            }

            unitOfWork.BeginTransaction();
            var ticketRepository = new TicketRepository(unitOfWork.Session);
            var clientRepository = new ClientRepository(unitOfWork.Session);
            clientRepository.Update(ticket.Client);
            ticketRepository.Insert(ticket);
            unitOfWork.Commit();

            Close();
        }
    }
}
