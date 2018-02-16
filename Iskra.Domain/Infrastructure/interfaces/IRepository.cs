using System;
using System.Linq;
using System.Linq.Expressions;

namespace Iskra.Domain.Models
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IQueryable<TEntity> SelectAll();
        TEntity GetBy(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> SelectBy(Expression<Func<TEntity, bool>> expression);
        int Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
