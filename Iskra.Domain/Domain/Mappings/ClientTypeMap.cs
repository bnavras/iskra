using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    public class ClientTypeMap : ClassMap<ClientType>
    {
        public ClientTypeMap()
        {
            Schema("public");
            Table("client_type");
            Id(clientType => clientType.Id).Column("client_type_id");
            Map(clientType => clientType.Title).Column("title");
        }
    }
}
