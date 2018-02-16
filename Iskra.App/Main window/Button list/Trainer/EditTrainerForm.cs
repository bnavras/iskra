using System;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class EditTrainerForm : Form
    {
        private readonly UnitOfWork unitOfWorck;
        private readonly Trainer trainer;
        public EditTrainerForm(Trainer trainer)
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWorck = new UnitOfWork(sessionFactory);
            this.trainer = trainer;
        }

        private void bSaveTrainer_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введите Ваше Имя!");
                return;
            }

            trainer.Birthday = dtpBirthday.Value;
            trainer.Comment = tbNotice.Text;
            trainer.Name = tbName.Text;
            trainer.Phone = tbPhoneNumber.Text;
      
            unitOfWorck.BeginTransaction();
            var trainerRepository = new TrainerRepository(unitOfWorck.Session);
            trainerRepository.Update(trainer);
            unitOfWorck.Commit();

            Close();
        }

        private void EditTrainerForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value = trainer.Birthday;
            tbNotice.Text = trainer.Comment;
            tbName.Text = trainer.Name;
            tbPhoneNumber.Text = trainer.Phone;
        }
    }
}
