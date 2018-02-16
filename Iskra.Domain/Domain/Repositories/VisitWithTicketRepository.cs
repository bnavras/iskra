using NHibernate;

namespace Iskra.Domain.Models
{
    public class VisitWithTicketRepository : BaseRepository<VisitWithTicket>
    {
        public VisitWithTicketRepository(ISession session)
            : base(session) { }
    }
}