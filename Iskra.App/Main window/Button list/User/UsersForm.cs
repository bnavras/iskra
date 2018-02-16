using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.App
{
    public partial class UsersForm : Form
    {
        private readonly UnitOfWork unitOfWork;
        public UsersForm()
        {
            InitializeComponent();        
            var sessionFactory = new FluentNHibernateHelper().SessionFactory;
            unitOfWork = new UnitOfWork(sessionFactory);

            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtAddUser_Click(object sender, EventArgs e)
        {
            new AddNewUserForm().ShowDialog();
        }

        private void BtEditUser_Click(object sender, EventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem as User;
            new EditUserForm(user).ShowDialog();
        }

        private void BtChangePasswordClick(object sender, EventArgs e)
        {
            new EditPasswordForm().ShowDialog();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            unitOfWork.BeginTransaction();
            var userRepasitory = new UserRepository(unitOfWork.Session);
            bsUsers.DataSource = userRepasitory.SelectAll().ToList();
            //TODO:refactor
            dgvUsers.Columns["Id"].Visible = false;
            dgvUsers.Columns["IsDeleted"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            //TODO:refactor
            var columnHeaders = new[]
            {
                "Имя", "Телефон", "День рождения", "Пароль", "Статус", "Тип пользователя", "Код"
            };
            for(var i = 0; i<dgvUsers.Columns.Count; i++)
                dgvUsers.Columns[i].HeaderText = columnHeaders[i];
        }
    }
}
