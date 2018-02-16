using System;

namespace Iskra.Domain.Models
{
    public class Variable : Entity<int>
    {
        private double variableValue;
        public virtual string Name { get; set; }
        public virtual double Value
        {
            get { return variableValue; }
            set { variableValue = value; StateChanged?.Invoke(value); }
        }
        public Variable() { }
        public Variable(int id) : base (id) { }
        public virtual event Action<double> StateChanged;
    }
}
