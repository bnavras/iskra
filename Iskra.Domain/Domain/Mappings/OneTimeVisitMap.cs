using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class OneTimeVisitMap : ClassMap<OneTimeVisit>
    {
        public OneTimeVisitMap()
        {
            Schema("public");
            Table("visit");
            Id(visit => visit.Id).Column("visit_id");
            Map(visit => visit.Cost).Column("sum");
            Map(visit => visit.VisitDate).Column("date");
            References(visit => visit.Client).Column("client_id");
            References(visit => visit.Duty).Column("session_id"); ;
            References(visit => visit.Trainer).Column("trainer_id"); ;
            References(visit => visit.TrainingType).Column("training_type_id"); ;
        }
    }
}
