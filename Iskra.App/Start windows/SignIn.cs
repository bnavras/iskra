using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class SignIn : Form
    {
        private readonly UnitOfWork unitOfWork;
        private readonly Authorization authorization;
        private readonly MainForm mainForm;
        public SignIn(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            authorization = new Authorization();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
        }
        private void cbuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && cbuser.DroppedDown == false)
                cbuser.DroppedDown = true;
            else if(e.KeyCode == Keys.Enter) tbpassword.Focus();
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btSignIn.Focus();
        }

        private void btSignIn_Click(object sender, System.EventArgs e)
        {
            var client = cbuser.SelectedValue as User;
            var authorized = authorization.CheckPassword(tbpassword.Text, 
                                                         client?.Password, 
                                                         new MD5PasswordEncryptor());
            if (authorized < 0)
            {
                MessageBox.Show("Неверный пароль");
                return;
            }
            mainForm.ActivateInterface(true);
            OpenShift();
            Close();
        }
        private void OpenShift()
        {
            unitOfWork.BeginTransaction();
            var variableRepository = new VariableRepository(unitOfWork.Session);
            var duryRepository = new DutyRepository(unitOfWork.Session);
            var startCashBalanc = variableRepository.Get(1);                           //TODO:refactor
            var startTerminalBalanc = variableRepository.Get(2);                       //TODO:refactor

            MainForm.Duty = new Duty();
            MainForm.Duty.OpenShift(
                user: cbuser.SelectedValue as User,
                startTime: DateTime.Now,
                startCashBalanc: startCashBalanc.Value,
                startTerminalBalanc: startTerminalBalanc.Value);

            duryRepository.Insert(MainForm.Duty);
            unitOfWork.Commit();
            mainForm.lSessionStatus.Text = "СМЕНА ОТКРЫТА";
            mainForm.lSessionStatus.ForeColor = Color.Black;
            mainForm.lСurrentUserName.Text = MainForm.Duty.User.Name;
        }

        private void SignIn_Load(object sender, System.EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var userRepository = new UserRepository(unitOfWork.Session);
            cbuser.DataSource = userRepository.SelectAll().ToList();
            cbuser.DisplayMember = "Name";
            unitOfWork.Session.Close();
        }
    }
}
