using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    public class OneTimeVisit : Visit
    {
        public virtual Client Client { get; set; }
        public virtual double Cost { get; set; }

        public OneTimeVisit() { }
        public OneTimeVisit(int id) : base(id)
        {
        }

        
    }
}
