using System.Collections.Generic;
using NHibernate;
using NHibernate.Transform;

namespace Iskra.Domain.Models
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(ISession session) 
            : base(session) { }
    }
}
