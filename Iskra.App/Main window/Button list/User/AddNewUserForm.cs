using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class AddNewUserForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public AddNewUserForm()
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
        }

        private void bCreateUser_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length < 3 || tbPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("Имя и пароль должны содержать не менее 3 символов!");
                return;
            }
            unitOfWork.BeginTransaction();
            var userRepository = new UserRepository(unitOfWork.Session);
            var user = new User()
            {
                Birthday = dtpBirthDay.Value,
                Name = tbName.Text,
                Password = new MD5PasswordEncryptor().CalculateHash(tbPassword.Text),
                Phone = tbPhoneNumber.Text,
                UserType = new UserType((int)cbPost.SelectedValue, cbPost.SelectedText)
            };
            userRepository.Insert(user);
            unitOfWork.Commit();

            Close();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var clientTypeRepository = new UserTypeRepository(unitOfWork.Session)
                .SelectAll()
                .ToList();
            cbPost.DataSource = clientTypeRepository;
            cbPost.DisplayMember = "Title";
            cbPost.ValueMember = "Id";
            unitOfWork.Commit();
        }
    }
}
