using System;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.App
{
    public partial class AddNewTrainerForm : Form
    {
        private readonly ISessionFactory sessionFactory;                 //TODO:refactor
        public AddNewTrainerForm()
        {
            InitializeComponent();
            sessionFactory = new FluentNHibernateHelper().SessionFactory;
        }

        private void bAddTrainer_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введите Ваше Имя!");
                return;
            }
            var newTrainer = new Trainer()
            {
                Birthday = dtpBirthday.Value,
                Comment = tbNotice.Text,
                Name = tbName.Text,
                Phone = tbPhoneNumber.Text,
            };
           
            var unitOfWorck = new UnitOfWork(sessionFactory);
            unitOfWorck.BeginTransaction();
            var trainerRepository = new TrainerRepository(unitOfWorck.Session);
            trainerRepository.Insert(newTrainer);
            unitOfWorck.Commit();

            Close();
        }
    }
}
