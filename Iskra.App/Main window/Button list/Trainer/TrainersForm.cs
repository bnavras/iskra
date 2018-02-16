using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.App
{
    public partial class TrainersForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public TrainersForm()
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
            
            dgvTrainers.AutoGenerateColumns = true;
            dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtAddTrainer_Click(object sender, EventArgs e)
        {
            new AddNewTrainerForm().ShowDialog();
        }

        private void BtEditTrainer_Click(object sender, EventArgs e)
        {
            var trainer = dgvTrainers.SelectedRows[0].DataBoundItem as Trainer;
            new EditTrainerForm(trainer).ShowDialog();
        }

        private void TrainersForm_Load(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var trainerRepasitory = new TrainerRepository(unitOfWork.Session);
            bsTrainers.DataSource = trainerRepasitory.SelectAll().ToList();
            unitOfWork.Session.Close();
            //TODO:refactor
            dgvTrainers.Columns["Id"].Visible = false;
            dgvTrainers.Columns["IsArchival"].Visible = false;
            dgvTrainers.Columns["TrainingTypes"].Visible = false;
            //TODO:rafactor
            var columnHeaders = new[]
            {
                "Имя", "Телефон", "День рождения", "Примечание",
                "Зарплата", "Статус", "Типы тренировок", "Id"
            };
            for (var i = 0; i < dgvTrainers.Columns.Count; i++)
                dgvTrainers.Columns[i].HeaderText = columnHeaders[i];           
        }
    }
}
