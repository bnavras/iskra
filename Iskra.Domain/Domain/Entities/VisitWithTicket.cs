using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskra.Domain.Models
{
    public class VisitWithTicket : Visit
    {
        public VisitWithTicket() { }
        public VisitWithTicket(int id) : base(id)
        {
        }

        public virtual Ticket Ticket { get; set; }
    }
}
