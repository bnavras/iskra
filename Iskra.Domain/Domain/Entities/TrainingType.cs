using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class TrainingType : Entity<int>
    {
        public TrainingType() { }
        public TrainingType(int id) : base(id)
        {
        }

        public virtual string Title { get; set; }
        public virtual double TicketSalary { get; set; }
        public virtual double OneTimeVisitSalary { get; set; }
        public virtual double MorningPrice { get; set; }
        public virtual double EveningPrice { get; set; }
        public virtual double DayPrice { get; set; }
        public virtual bool IsArchival { get; set; }
        public virtual IList<Trainer> Trainers { get; set; }
    }
}
