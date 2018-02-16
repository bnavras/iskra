using NHibernate;

namespace Iskra.Domain.Models
{
    public class TrainingTypeRepository : BaseRepository<TrainingType>
    {
        public TrainingTypeRepository(ISession session) 
            : base(session) { }
    }
}
