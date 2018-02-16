using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    public class VariableMap : ClassMap<Variable>
    {
        public VariableMap()
        {
            Table("variable");
            Id(variable => variable.Id).Column("variable_id");
            Map(variable => variable.Name).Column("name");
            Map(variable => variable.Value).Column("value");
        }
    }
}
