using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class VisitWithTicketMap : ClassMap<VisitWithTicket>
    {
        public VisitWithTicketMap()
        {
            Schema("public");
            Table("ticket_visit");
            Id(visit => visit.Id).Column("ticket_visit_id");
            Map(visit => visit.VisitDate).Column("date");
            References(visit => visit.Ticket).Column("ticket_id");
            References(visit => visit.Duty).Column("session_id"); ;
            //References(visit => visit.RentedEquipment).Column("rent_id"); ;
            References(visit => visit.Trainer).Column("trainer_id"); ;
            References(visit => visit.TrainingType).Column("training_type_id"); ;
        }
    }
}
