using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate.Linq;

namespace Iskra.App
{
    public partial class MainForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public static Duty Duty;
        public readonly IList<Variable> Variable;

        public MainForm()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = true;
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
            unitOfWork.BeginTransaction();
            Variable = new VariableRepository(unitOfWork.Session).SelectAll().ToList();
            unitOfWork.Session.Close();
            //TODO:rafactor
            Variable.Single(variable => variable.Name == "cashBalanc").StateChanged += 
                value => lCashBalanc.Text = value.ToString(); 
            Variable.Single(variable => variable.Name == "terminalBalanc").StateChanged +=
                value => lTerminalBalanc.Text = value.ToString();
        }

        private void DrawTable(BindingSource bindingSource, string[] columnNames)
        {
            dgv.DataSource = bindingSource;

            for (var i = 0; i < dgv.Columns.Count; i++)
                dgv.Columns[i].HeaderText = columnNames[i];
        }

        private void BtShowVisits_Click(object sender, EventArgs e)
        {
            var columnHeaders = new[]
            {
                "Клиент", "Тренер", "Занятие", "Время", "Администратор",
                "Код абонемента", "Стоимость", "Тип", "Id"
            };

            DrawTable(bsVisits, columnHeaders);
            dgv.Columns["Id"].Visible = false;
            SetStatusOfButtonTabs(false, true, true);
        }

        private void BtShowSubscriptionSales_Click(object sender, EventArgs e)
        {
            //TODO:refactor
            var columnHeaders = new[]
            {
                "Тип", "Клиент", "Скидка", "Администратор", "Осталось визитов",
                "Дата покупки", "К оплате", "Cрок действия", "Статус", "Заморозка", "Id"
            };
            //TODO:refactor
            DrawTable(bsTicketSale, columnHeaders);
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["IsArchival"].Visible = false;
            SetStatusOfButtonTabs(true, false, true);
        }

        private void BtShowBarSale_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MiListsClients_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
        }

        private void MiListsSubscription_Click(object sender, EventArgs e)
        {
            new TicketsForm().ShowDialog();
        }

        private void MiListsCoaches_Click(object sender, EventArgs e)
        {
            new TrainersForm().ShowDialog();
        }

        private void MiListsUsers_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void MiListsDirectionsTraining_Click(object sender, EventArgs e)
        {
            new DirectionsTrainingForm().ShowDialog();
        }

        private void MiListsDiscounts_Click(object sender, EventArgs e)
        {
            new DiscontsForm().ShowDialog();
        }

        private void MiBarProductСatalog_Click(object sender, EventArgs e)
        {
            new CatalogForm().ShowDialog();
        }

        private void MiBarVendors_Click(object sender, EventArgs e)
        {
            new AddVenderForm().ShowDialog();
        }

        private void MiFileLoginAs_Click(object sender, EventArgs e)
        {
            new SignIn(this).ShowDialog();
        }

        private void MiFileChangePassword_Click(object sender, EventArgs e)
        {
            new EditPasswordForm().ShowDialog();
        }

        private void btNewVisitor_Click(object sender, EventArgs e)
        {
            new AddVisitForm().ShowDialog();
        }

        private void btSellSubscription_Click(object sender, EventArgs e)
        {
            new SellTicketForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (unitOfWork.BeginTransaction() < 0)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
                return;
            }

            var ticketRepository = new TicketRepository(unitOfWork.Session);
            var visitRepository = new CommonVisitRepository(unitOfWork.Session);
            var a = visitRepository.SelectAll().ToList();
            bsVisits.DataSource = visitRepository.SelectAll().ToList();
            bsTicketSale.DataSource = ticketRepository.SelectAll().ToList();
            BtShowVisits_Click(null, null);
            //TODO:refactor
            Variable[0].Value = Variable[0].Value;
            Variable[1].Value = Variable[1].Value;

            SetStatusOfButtonTabs(false, true, true);
        }

        private void SetStatusOfButtonTabs(bool visitsStatus, bool ticketsStatus, bool barStatus)
        {
            btShowVisits.Enabled = visitsStatus;
            btShowSubscriptionSales.Enabled = ticketsStatus;
            btShowBarSale.Enabled = barStatus;
        }

        private void miFileCloseSession_Click(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var variableRepository = new VariableRepository(unitOfWork.Session);
            var duryRepository = new DutyRepository(unitOfWork.Session);
            var finishCashBalanc = variableRepository.Get(1);
            var finishTerminalBalanc = variableRepository.Get(2);
            
            Duty.CloseShift(
                finishTime: DateTime.Now,
                finishCashBalanc: finishCashBalanc.Value,
                finishTerminalBalanc: finishTerminalBalanc.Value);
            duryRepository.Update(Duty);
            unitOfWork.Commit();
            lSessionStatus.Text = "СМЕНА НЕ ОТКРЫТА";
            lSessionStatus.ForeColor = Color.Red;
            lСurrentUserName.Text = "Вход не выполнен!";
            ActivateInterface(false);
        }

        public void ActivateInterface(bool status)
        {
            miBar.Enabled = status;
            miLists.Enabled = status;
            miCash.Enabled = status;
            miReports.Enabled = status;
            miSettings.Enabled = status;
            pCommands.Enabled = status;
        }
    }
}