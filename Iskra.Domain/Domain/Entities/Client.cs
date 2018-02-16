using System;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class Client : Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Barcode { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual string Gender { get; set; }
        public virtual ClientType ClientType { get; set; }
        public virtual double Credit { get; set; }
        public virtual string Phone { get; set; }
        public virtual Ticket LastTicket { get; set; }
        public virtual bool IsArchival { get; set; }
        public virtual string Comment { get; set; }


        public Client() { }
        public Client(int id) : base(id)
        {
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
