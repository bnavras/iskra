using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Domain.Models;
using NHibernate;

namespace Iskra.Domain.Models
{
    public class ClientTypeRepository : BaseRepository<ClientType>
    {
        public ClientTypeRepository(ISession session)
            : base(session) { }
    }
}
