using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class TicketMap : ClassMap<Ticket>
    {
        public TicketMap()
        {
            Schema("public");
            Table("ticket");
            Id(ticket => ticket.Id).Column("ticket_id");
            Map(ticket => ticket.ExpirationTime).Column("expiration");
            Map(ticket => ticket.IsFrozen).Column("frozen");
            Map(ticket => ticket.TotalCost).Column("total_sum");
            Map(ticket => ticket.VisitQuantity).Column("visit_quantity"); ;
            Map(ticket => ticket.SellTime).Column("sell_data");
            Map(ticket => ticket.IsArchival).Column("deleted");
            References(ticket => ticket.Duty).Column("session_id");
            References(ticket => ticket.Client).Column("client_id"); 
            References(ticket => ticket.Discount).Column("discount_id");
            References(ticket => ticket.TicketType).Column("ticket_type_id");
        }
    }
}
