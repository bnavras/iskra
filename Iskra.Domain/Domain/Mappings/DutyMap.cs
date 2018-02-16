using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class DutyMap : ClassMap<Duty>
    {
        public DutyMap()
        {
            Schema("public");
            Table("session");
            Id(duty => duty.Id).Column("session_id");
            Map(duty => duty.StartTime).Column("date_start");
            Map(duty => duty.StartCashBalance).Column("start_cash_sum");
            Map(duty => duty.StartTerminalBalanc).Column("start_terminal_sum");
            Map(duty => duty.FinishTime).Column("date_finish");
            Map(duty => duty.FinishCashBalance).Column("finish_cash_sum");
            Map(duty => duty.FinishTerminalBalanc).Column("finish_terminal_sum");
            References(duty => duty.User).Column("user_id");
        }
    }
}
