using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Domain.Models;
using NHibernate;

namespace Iskra.Domain.Models
{
    public class DiscountRepository : BaseRepository<Discount>
    {
        public DiscountRepository(ISession session) 
            : base(session) { }
    }
}
