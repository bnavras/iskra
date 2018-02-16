using NHibernate;

namespace Iskra.Domain.Models
{
    public class OneTimeVisitRepository : BaseRepository<OneTimeVisit>
    {
        public OneTimeVisitRepository(ISession session)
            : base(session) { }
    }
}

