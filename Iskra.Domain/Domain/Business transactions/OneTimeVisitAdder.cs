using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class OneTimeVisitAdder
    {
        public void AddOneTimeVisit(OneTimeVisit visit)
        {
            var session = new FluentNHibernateHelper().SessionFactory;
            using (var unitOfWork = new UnitOfWork(session))
            {
                unitOfWork.BeginTransaction();
                var trainerRepository = new TrainerRepository(unitOfWork.Session);
                var visitRepository = new OneTimeVisitRepository(unitOfWork.Session);
                // Начисляем зарплату тренеру
                visit.Trainer.SalaryDebt += visit.TrainingType.OneTimeVisitSalary;
                // Внесение данных в базу данных
                visitRepository.Insert(visit);
                trainerRepository.Update(visit.Trainer);
                unitOfWork.Commit();
            }
        }
    }
}
