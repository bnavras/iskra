using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class TransactionType : Entity<int>
    {
        public TransactionType() { }
        public TransactionType(int id) : base(id)
        {
        }
        public virtual string Title { get; set; }
        public virtual bool IsArchival { get; set; }
    }
}
