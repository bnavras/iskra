using Iskra.Domain.Models;
using NHibernate;

namespace Iskra.Domain.Models
{
    public class DutyRepository : BaseRepository<Duty>
    {
        public DutyRepository(ISession session) 
            : base(session) { }
    }
}
