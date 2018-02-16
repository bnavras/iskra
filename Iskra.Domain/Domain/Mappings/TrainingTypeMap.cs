using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class TrainingTypeMap : ClassMap<TrainingType>
    {
        public TrainingTypeMap()
        {
            Schema("public");
            Table("training_type");
            Id(trainingType => trainingType.Id).Column("training_type_id");
            Map(trainingType => trainingType.Title).Column("title");
            Map(trainingType => trainingType.IsArchival).Column("deleted");
            Map(trainingType => trainingType.DayPrice).Column("day_price");
            Map(trainingType => trainingType.EveningPrice).Column("evening_price");
            Map(trainingType => trainingType.MorningPrice).Column("morning_price");
            Map(trainingType => trainingType.OneTimeVisitSalary).Column("salary_visit");
            Map(trainingType => trainingType.TicketSalary).Column("salary_ticket");

            HasManyToMany(trainingType => trainingType.Trainers)
                .Table("trainer_training_type")
                .Cascade.All();
        }
    }
}
