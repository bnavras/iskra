using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Schema("public");
            Table("client");
            Id(client => client.Id).Column("client_id");
            Map(client => client.Name).Column("fio");
            Map(client => client.Barcode).Column("barcode");
            Map(client => client.Birthday).Column("birthdate");
            Map(client => client.Credit).Column("credit");
            Map(client => client.Email).Column("email");
            Map(client => client.Phone).Column("phone");
            Map(client => client.Gender).Column("gender");
            Map(client => client.IsArchival).Column("deleted");
            Map(client => client.Comment).Column("info");
            References(client => client.ClientType).Column("client_type_id");
            References(client => client.LastTicket).Column("last_ticket");
        }
    }
}
