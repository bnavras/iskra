using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class TicketTypeMap : ClassMap<TicketType>
    {
        public TicketTypeMap()
        {
            Schema("public");
            Table("ticket_type");
            Id(ticketType => ticketType.Id).Column("ticket_type_id");
            Map(ticketType => ticketType.Title).Column("title");
            Map(ticketType => ticketType.Nominal).Column("nominal");
            Map(ticketType => ticketType.TrainingCount).Column("lesson_count");
            Map(ticketType => ticketType.IsArchival).Column("deleted");
        }
    }
}
