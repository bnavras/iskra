using System;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public abstract class Visit : Entity<int>
    {
        protected Visit() { }
        protected Visit(int id) : base(id)
        {
        }

        //public virtual List<Equipment> RentedEquipment { get; set; }
        public virtual Duty Duty { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual TrainingType TrainingType { get; set; }
        public virtual DateTime VisitDate { get; set; }
    }
}
