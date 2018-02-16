using NHibernate;

namespace Iskra.Domain.Models
{
    public class TicketRepository : BaseRepository<Ticket>
    {
        public TicketRepository(ISession session)
            : base(session) { }
    }
}