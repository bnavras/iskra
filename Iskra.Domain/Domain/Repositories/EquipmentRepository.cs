using NHibernate;

namespace Iskra.Domain.Models
{
    public class EquipmentRepository : BaseRepository<Equipment>
    {
        public EquipmentRepository(ISession session)
            : base(session) { }
    }
}