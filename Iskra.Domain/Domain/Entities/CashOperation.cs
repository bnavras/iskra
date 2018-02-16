using System;
using Iskra.Infrastructure;

namespace Iskra.Domain.Models
{
    public class CashOperation : Entity<int>
    {
        public CashOperation() { }
        public CashOperation(int id) : base(id)
        {
        }

        public virtual Duty Duty { get; set; }
        public virtual Trainer Payee { get; set; }
        public virtual double SumOfMoney { get; set; }
        public virtual string Comment { get; set; }
        public virtual DateTime TransactionTime { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
