using NHibernate;

namespace Iskra.Domain.Models
{
    public class TicketTypeRepository : BaseRepository<TicketType>
    {
        public TicketTypeRepository(ISession session) 
            : base(session) { }
    }
}
