using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class User : Entity<int>
    {
        public User() { }
        public User(int id) : base(id)
        {
        }

        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual string Password { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
