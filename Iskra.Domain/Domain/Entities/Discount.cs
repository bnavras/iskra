using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class Discount : Entity<int>
    {
        public Discount() { }
        public Discount(int id) : base(id)
        {
        }

        public virtual string Title { get; set; }
        public virtual double Percent { get; set; }
        public virtual bool IsArchival { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Percent}%";
        }
    }
}
