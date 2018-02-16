using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class TicketType : Entity<int>
    {
        public TicketType() { }
        public TicketType(int id) : base(id)
        {
        }

        public virtual string Title { get; set; }
        public virtual double Nominal { get; set; }
        public virtual int TrainingCount { get; set; }
        public virtual bool IsArchival { get; set; }
        public virtual double CalculateFullCost(double discount)
        {
            return Nominal * (1 - discount / 100);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
