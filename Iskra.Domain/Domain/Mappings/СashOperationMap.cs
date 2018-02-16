using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    public class СashOperationMap : ClassMap<CashOperation>
    {
        public СashOperationMap()
        {
            Schema("public");
            Table("cash_operation");
            Id(cashOperation => cashOperation.Id).Column("cash_operation_id");
            Map(cashOperation => cashOperation.Comment).Column("comment");
            Map(cashOperation => cashOperation.SumOfMoney).Column("summ");
            Map(cashOperation => cashOperation.TransactionTime).Column("date");
            References(cashOperation => cashOperation.Payee).Column("payee_id");
            References(cashOperation => cashOperation.Duty).Column("session_id");
            References(cashOperation => cashOperation.TransactionType).Column("cash_operation_type");
        }
    }
}
