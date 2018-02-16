using NHibernate;

namespace Iskra.Domain.Models
{
    public class UserTypeRepository : BaseRepository<UserType>
    {
        public UserTypeRepository(ISession session) 
            : base(session) { }
    }
}
