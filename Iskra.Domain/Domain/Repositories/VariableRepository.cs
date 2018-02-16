using Iskra.Domain.Models;
using Iskra.Infrastructure;
using NHibernate;

namespace Iskra.Domain.Models
{
    public class VariableRepository : BaseRepository<Variable>
    {
        public VariableRepository(ISession session) 
            : base(session) { }
    }
}
