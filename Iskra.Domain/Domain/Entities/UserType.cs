using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class UserType : Entity<int>
    {
        public UserType() { }
        public UserType(int id, string title) : base(id)
        {
            Title = title;
        }

        public virtual string Title { get; set; }
        public virtual IList<User> Users { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
