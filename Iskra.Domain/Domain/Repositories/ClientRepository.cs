using NHibernate;

namespace Iskra.Domain.Models
{
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(ISession session)
            : base(session) { }
    }
}
