using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class Trainer : Entity<int>
    {
        public Trainer() { }
        public Trainer(int id) : base(id)
        {
        }

        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual string Comment { get; set; }
        public virtual double SalaryDebt { get; set; }
        public virtual bool IsArchival { get; set; }
        public virtual IList<TrainingType> TrainingTypes { get; set; }
    }
}
