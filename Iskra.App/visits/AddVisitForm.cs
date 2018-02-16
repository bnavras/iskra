using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class AddVisitForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public AddVisitForm()
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
        }
        private void bTabByOne_Click(object sender, EventArgs e)
        {
            btTabByOne.BackColor = Color.NavajoWhite;
            btTabByTicket.BackColor = Color.Empty;
            pTicketVisit.Visible = false;
            pOnec.Visible = true;
        }

        private void bTabByTicket_Click(object sender, EventArgs e)
        {
            btTabByTicket.BackColor = Color.NavajoWhite;
            btTabByOne.BackColor = Color.Empty;
            pOnec.Visible = false;
            pTicketVisit.Visible = true;
        }

        private void btCreateVisit_Click(object sender, EventArgs e)
        {
            if (pOnec.Visible) AddOneTimeVisit();
            else AddTicketVisit();
        }

        private OneTimeVisit GetSelectedOneTimeVisit()
        {
            var selectedTraining = cbTabOneTrainingType.SelectedValue as TrainingType;
            return new OneTimeVisit()
            {
                Client = cbTabOnecClient.SelectedValue as Client,
                Cost = double.Parse(tbTabOnecCost.Text),
                Duty = MainForm.Duty,
                Trainer = cbTabOnecTrainer.SelectedValue as Trainer,
                TrainingType = selectedTraining,
                VisitDate = DateTime.Now
            };
        }

        private void AddOneTimeVisit()
        {
            var visit = GetSelectedOneTimeVisit();

            if (visit.Duty == null)
            {
                MessageBox.Show("Откройте смену!");
                return;
            }
            if (visit.Client == null || visit.Trainer == null || visit.TrainingType == null)
            {
                MessageBox.Show("Не все данные корректно введены!");
                return;
            }

            new OneTimeVisitAdder().AddOneTimeVisit(visit);
            Close();
        }

        private void AddTicketVisit()
        {
            var visit = GetSelectedTicketVisit();

            if (visit.Duty == null)
            {
                MessageBox.Show("Откройте смену!");
                return;
            }
            if (visit.Ticket == null || visit.Trainer == null || visit.TrainingType == null)
            {
                MessageBox.Show("Не все данные корректно введены!");
                return;
            }

            new VisitWithTicketAdder().AddVisitWithTicker(visit);
            Close();
        }

        private VisitWithTicket GetSelectedTicketVisit()
        {
            return new VisitWithTicket()
            {
                Duty = MainForm.Duty,
                Trainer = cbFirstTabTrainer.SelectedValue as Trainer,
                TrainingType = cbFirstTabTrainingType.SelectedValue as TrainingType,
                VisitDate = DateTime.Now,
                Ticket = cbFirstTabTicket.SelectedValue as Ticket
            };
        }

        private void LoadClients()
        {
            unitOfWork.BeginTransaction();
            var clientRepository = new ClientRepository(unitOfWork.Session);
            var clients = clientRepository.SelectAll().ToList();
            cbFirstTabClient.DataSource = cbTabOnecClient.DataSource = clients;
            cbFirstTabClient.DisplayMember = cbTabOnecClient.DisplayMember = "Name";
            unitOfWork.Commit();
        }

        private void LoadTrainingType()
        {
            unitOfWork.BeginTransaction();
            var trainingRepository = new TrainingTypeRepository(unitOfWork.Session);
            var training = trainingRepository.SelectAll().ToList();
            cbFirstTabTrainingType.DataSource = cbTabOneTrainingType.DataSource = training;
            cbFirstTabTrainingType.DisplayMember = cbTabOneTrainingType.DisplayMember = "Title";
            unitOfWork.Commit();
        }

        private void LoadTrainers(TrainingType selectedTraining, ComboBox combo)
        {
            if (selectedTraining != null)
                combo.DataSource = selectedTraining.Trainers;
            else combo.DataSource = new List<Trainer>();
            combo.DisplayMember = "Name";
        }

        private void LoadClientCode(Client selectedClient, TextBox textBox)
        {
            if (selectedClient != null)
                textBox.Text = selectedClient.Barcode;
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadTrainingType();
        }

        private void cbTabOneTrainingType_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedTraining = cbTabOneTrainingType.SelectedValue as TrainingType;
            LoadTrainers(selectedTraining, cbTabOnecTrainer);
            tbTabOnecCost.Text = CalculateFullCost(selectedTraining).ToString();
        }
        private void cbFirstTabTrainingType_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedTraining = cbTabOneTrainingType.SelectedValue as TrainingType;
            LoadTrainers(selectedTraining, cbFirstTabTrainer);
        }

        private void cbFirstTabClient_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClient = cbTabOnecClient.SelectedValue as Client;
            if (selectedClient == null) return;
            LoadClientCode(selectedClient, tbTabOnecCode);
            tbFirstTabCode.Text = selectedClient.Barcode;
            cbFirstTabTicket.DataSource = GetClientTickets(selectedClient.Id);
        }

        private IList<Ticket> GetClientTickets(int id)
        {
            unitOfWork.BeginTransaction();
            var ticketRepository = new TicketRepository(unitOfWork.Session);
            return ticketRepository.SelectBy(ticket => ticket.Client.Id == id).ToList();
        }

        private void cbTabOnecClient_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClient = cbFirstTabClient.SelectedValue as Client;
            LoadClientCode(selectedClient, tbFirstTabCode);
        }
        private double CalculateFullCost(TrainingType trainingType)    //TODO: refactor
        {
            if (trainingType == null) return -1;
            return DateTime.Now.Hour <= 18
                ? trainingType.DayPrice
                : trainingType.EveningPrice;
        }
        private void cbFirstTabTicket_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedTicket = cbFirstTabTicket.SelectedValue as Ticket;
            tbFirstTabExpiration.Text = selectedTicket?.ExpirationTime.ToString();
            tbVisitLimit.Text = selectedTicket?.VisitQuantity.ToString();
        }
    }
}
