using System;
using System.Linq;
using System.Windows.Forms;
using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.App
{
    public partial class DiscontsForm : Form
    {
        private readonly ISessionFactory sessionFactory;
        public DiscontsForm()
        {
            InitializeComponent();
            sessionFactory = new FluentNHibernateHelper().SessionFactory;
            dgvDiscounts.AutoGenerateColumns = true;
            dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DiscontsForm_Load(object sender, EventArgs e)
        {
            var unitOfWorck = new UnitOfWork(sessionFactory);
            unitOfWorck.BeginTransaction();
            var userRepasitory = new DiscountRepository(unitOfWorck.Session);
            bsDiscounts.DataSource = userRepasitory.SelectAll().ToList();
            //TODO:refactor
            dgvDiscounts.Columns["Id"].Visible = false;
            dgvDiscounts.Columns["IsArchival"].Visible = false;
            dgvDiscounts.Columns["Title"].HeaderText = "Название";
            dgvDiscounts.Columns["Percent"].HeaderText = "Скидка";
        }
    }
}
