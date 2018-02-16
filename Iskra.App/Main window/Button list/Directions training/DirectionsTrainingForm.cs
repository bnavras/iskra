using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;
using NHibernate.Util;

namespace Iskra.App
{
    public partial class DirectionsTrainingForm : Form
    {
        private readonly ISessionFactory sessionFactory;
        private TrainingTypeRepository trainingTypeRepository;
        public DirectionsTrainingForm()
        {
            InitializeComponent();
            sessionFactory = new FluentNHibernateHelper().SessionFactory;
            dgvDirectionsTraining.AutoGenerateColumns = true;
            dgvDirectionsTraining.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainer.AutoGenerateColumns = true;
            dgvTrainer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void BtTrainer_Click(object sender, EventArgs e)
        {
            new AddNewTrainerForm().ShowDialog();
        }

        private void DirectionsTrainingForm_Load(object sender, EventArgs e)
        {
            var unitOfWorck = new UnitOfWork(sessionFactory);
            unitOfWorck.BeginTransaction();
            trainingTypeRepository = new TrainingTypeRepository(unitOfWorck.Session);
            bsDirectionsTraining.DataSource = trainingTypeRepository.SelectAll().ToList();

            dgvDirectionsTraining.Columns["Id"].Visible = false;
            dgvDirectionsTraining.Columns["IsArchival"].Visible = false;
            dgvDirectionsTraining.Columns["Trainers"].Visible = false;

            var columnHeaders = new[]                                                                     //TODO:refactor
            {
                "Название", "Зарплата (по абонементу)", "Зарплата (без абонемента)",
                "Стоимость (Утро)", "Стоимость (Вечер)", "Стоимость (День)", "Статус", "Тренеры", "Id"
            };
            for (var i = 0; i < dgvDirectionsTraining.Columns.Count; i++)
                dgvDirectionsTraining.Columns[i].HeaderText = columnHeaders[i];
        }

        private void dgvDirectionsTraining_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTrainer = (DataGridViewRow)dgvDirectionsTraining.SelectedRows.FirstOrNull();
            var trainerId = selectedTrainer?.Cells["Id"].Value;
            if (trainerId != null)
                bsTrainers.DataSource = trainingTypeRepository.Get((int)trainerId).Trainers;
            else bsTrainers.DataSource = new List<Trainer>();

            dgvTrainer.Columns["Name"].HeaderText = "Имя";
            foreach (DataGridViewColumn column in dgvTrainer.Columns)
                if (column.Name != "Name")
                    column.Visible = false;
        }
    }
}
