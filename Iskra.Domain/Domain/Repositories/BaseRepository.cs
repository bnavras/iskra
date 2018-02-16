using System;
using System.Linq;
using System.Linq.Expressions;
using Iskra.Infrastructure;
using NHibernate;
using NHibernate.Linq;

namespace Iskra.Domain.Models
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ISession Session { get; }

        protected BaseRepository(ISession session)
        {
            Session = session;
        }

        public TEntity Get(int id)
        {
            return Session.Get<TEntity>(id);
        }

        public IQueryable<TEntity> SelectAll()
        {
            return Session.Query<TEntity>();
        }

        public TEntity GetBy(Expression<Func<TEntity, bool>> expression)
        {
            return SelectAll().Where(expression).SingleOrDefault();
        }
        public IQueryable<TEntity> SelectBy(Expression<Func<TEntity, bool>> expression)
        {
            return SelectAll().Where(expression).AsQueryable();
        }

        public int Insert(TEntity entity)
        {
            var savedId = (int)Session.Save(entity);
            Session.Flush();
            return savedId;
        }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
            Session.Flush();
        }
    }
}
