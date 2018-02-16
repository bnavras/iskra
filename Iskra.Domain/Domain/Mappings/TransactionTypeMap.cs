using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class TransactionTypeMap : ClassMap<TransactionType>
    {
        public TransactionTypeMap()
        {
            Schema("public");
            Table("cash_operation_type");
            Id(transactionType => transactionType.Id).Column("cash_operation_type");
            Map(transactionType => transactionType.Title).Column("title"); ;
            Map(transactionType => transactionType.IsArchival).Column("deleted"); ;
        }
    }
}
