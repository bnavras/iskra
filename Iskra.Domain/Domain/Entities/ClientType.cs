using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskra.Domain.Models
{
    public class ClientType
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public ClientType() { }
        public ClientType(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
