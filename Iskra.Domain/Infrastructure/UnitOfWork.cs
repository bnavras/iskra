using System;
using NHibernate;

namespace Iskra.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public static UnitOfWork Current
        {
            get { return current; }
            set { current = value; }
        }

        [ThreadStatic] private static UnitOfWork current;

        public ISession Session { get; private set; }

        private readonly ISessionFactory _sessionFactory;

        private ITransaction transaction;

        public UnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public int BeginTransaction()
        {
            try
            {
                Session = _sessionFactory.OpenSession();
                transaction = Session.BeginTransaction();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            finally
            {
                Session.Close();
            }
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            finally
            {
                Session.Close();
            }
        }

        public void Dispose()
        {
            if (!transaction.WasCommitted && !transaction.WasRolledBack)
            {
                transaction.Rollback();
            }
            transaction.Dispose();
            transaction = null;

            Session.Dispose();
        }
    }
}