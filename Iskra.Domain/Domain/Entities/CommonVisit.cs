using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class CommonVisit : Entity<int>
    {
        public virtual string ClientName { get; set; }
        public virtual string TrainerName { get; set; }
        public virtual string TrainingType { get; set; }
        public virtual DateTime VisitDate { get; set; }
        public virtual string Duty { get; set; }
        public virtual int TicketId { get; set; }
        public virtual double Cost { get; set; }
        public virtual string VisitType { get; set; }

        public CommonVisit() { }
        public CommonVisit(int id) : base(id) { }
    }
}
