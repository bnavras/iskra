using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class TrainerMap : ClassMap<Trainer>
    {
        public TrainerMap()
        {
            Schema("public");
            Table("trainer");
            Id(trainer => trainer.Id).Column("trainer_id");
            Map(trainer => trainer.Name).Column("fio");
            Map(trainer => trainer.Birthday).Column("birthdate");
            Map(trainer => trainer.Phone).Column("phone");
            Map(trainer => trainer.SalaryDebt).Column("salary_debt");
            Map(trainer => trainer.Comment).Column("info");
            Map(trainer => trainer.IsArchival).Column("deleted");
            HasManyToMany(trainer => trainer.TrainingTypes)
                .Table("trainer_training_type")
                .Cascade.All();
        }
    }
}
