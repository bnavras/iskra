using System;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class Duty : Entity<int>
    {
        public virtual User User { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime FinishTime { get; set; }
        public virtual double StartCashBalance { get; set; }
        public virtual double FinishCashBalance { get; set; }
        public virtual double StartTerminalBalanc { get; set; }
        public virtual double FinishTerminalBalanc { get; set; }
        public Duty() { }
        public Duty(int id) : base(id) { }

        public virtual void OpenShift(User user, DateTime startTime, 
            double startCashBalanc, double startTerminalBalanc)
        {
            User = user;
            StartTime = startTime;
            StartCashBalance = startCashBalanc;
            StartTerminalBalanc = startTerminalBalanc;
        }
        public virtual void CloseShift(DateTime finishTime, double finishCashBalanc, double finishTerminalBalanc)
        {
            FinishTime= finishTime;
            FinishCashBalance = finishCashBalanc;
            FinishTerminalBalanc = finishTerminalBalanc;
        }

        public override string ToString()
        {
            return User.Name;
        }
    }
}
