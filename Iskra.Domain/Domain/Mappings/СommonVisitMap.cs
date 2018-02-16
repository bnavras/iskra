using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace Iskra.Domain.Models
{
    public class CommonVisitMap : ClassMap<CommonVisit>
    {
        public CommonVisitMap()
        {
            Table("visits");
            ReadOnly();

            Id(visit => visit.Id).Column("visit_id");
            Map(visit => visit.ClientName).Column("client");
            Map(visit => visit.Cost).Column("cost");
            Map(visit => visit.TicketId).Column("ticket_id");
            Map(visit => visit.Duty).Column("duty");
            Map(visit => visit.TrainerName).Column("trainer");
            Map(visit => visit.TrainingType).Column("training_type");
            Map(visit => visit.VisitDate).Column("date");
            Id(visit => visit.VisitType).Column("visit_type");
        }
    }
}
