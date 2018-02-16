using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class EditUserForm : Form
    {
        private readonly User user;
        private readonly UnitOfWork unitOfWork;
        public EditUserForm(User user)
        {
            InitializeComponent();
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);
            this.user = user;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var clientTypeRepository = new UserTypeRepository(unitOfWork.Session)
                .SelectAll()
                .ToList();
            cbPost.DataSource = clientTypeRepository;
            cbPost.DisplayMember = "Title";
            unitOfWork.Commit();

            tbName.Text = user.Name;
            dtpBirthDay.Value = user.Birthday;
            tbPhoneNumber.Text = user.Phone;
            cbPost.SelectedIndex = cbPost.FindString(user.UserType.Title);
        }

        private void bSaveUser_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Имя должно содержать не менее 3 символов!");
                return;
            }
            unitOfWork.BeginTransaction();
            var userRepository = new UserRepository(unitOfWork.Session);
            user.Name = tbName.Text;
            user.Birthday = dtpBirthDay.Value;
            user.Phone = tbPhoneNumber.Text;
            user.UserType = cbPost.SelectedValue as UserType;
            userRepository.Update(user);
            unitOfWork.Commit();

            Close();
        }
    }
}
