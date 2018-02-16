using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Domain.Models;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class Ticket : Entity<int>
    {
        public virtual TicketType TicketType { get; set; }
        public virtual Client Client { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Duty Duty { get; set; }
        public virtual int VisitQuantity { get; set; }
        public virtual DateTime SellTime { get; set; }
        public virtual double TotalCost { get; set; }
        public virtual DateTime ExpirationTime { get; set; }
        public virtual bool IsArchival { get; set; }
        public virtual bool IsFrozen { get; set; }
        public Ticket() { }
        public Ticket(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return $"{TicketType.Title}:{SellTime.Date} ({Id})";
        }
    }
}
