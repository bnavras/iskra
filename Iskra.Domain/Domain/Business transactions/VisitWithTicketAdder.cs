using System;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class VisitWithTicketAdder
    {
        public void AddVisitWithTicker(VisitWithTicket visitWithTicket)
        {
            var session = new FluentNHibernateHelper().SessionFactory;
            using (var unitOfWork = new UnitOfWork(session))
            {
                unitOfWork.BeginTransaction();
                var ticketRepository = new TicketRepository(unitOfWork.Session);
                var trainerRepository = new TrainerRepository(unitOfWork.Session);
                var visitRepository = new VisitWithTicketRepository(unitOfWork.Session);
                // Уменьшаем количество оставщихся посещений
                // Удаляем абонемент, если количество оставщихся посещений стало равно нулю
                visitWithTicket.Ticket.VisitQuantity--;
                if (visitWithTicket.Ticket.VisitQuantity == 0)
                    visitWithTicket.Ticket.IsArchival = true;
                // Начисляем зарплату тренеру
                visitWithTicket.Trainer.SalaryDebt += visitWithTicket.TrainingType.TicketSalary;
                // Внесение данных в базу данных
                visitRepository.Insert(visitWithTicket);
                ticketRepository.Update(visitWithTicket.Ticket);
                trainerRepository.Update(visitWithTicket.Trainer);
                unitOfWork.Commit();
            }
        }

    }
}
