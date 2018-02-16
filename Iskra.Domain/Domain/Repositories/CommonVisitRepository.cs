using NHibernate;

namespace Iskra.Domain.Models
{
    public class CommonVisitRepository : BaseRepository<CommonVisit>
    {
        public CommonVisitRepository(ISession session) 
            : base(session) { }
    }
}
