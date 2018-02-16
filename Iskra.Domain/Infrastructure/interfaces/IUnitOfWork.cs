using System;

namespace Iskra.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        int BeginTransaction();
        void Commit();
        void Rollback();
    }
}
