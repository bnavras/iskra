using NHibernate;

namespace Iskra.Domain.Models
{
    public class TrainerRepository : BaseRepository<Trainer>
    {
        public TrainerRepository(ISession session)
            : base(session) { }
    }
}