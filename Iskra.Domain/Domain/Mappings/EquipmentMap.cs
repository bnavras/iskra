using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class EquipmentMap : ClassMap<Equipment>
    {
        public EquipmentMap()
        {
            Schema("public");
            Table("rent_item");
            Id(equipment => equipment.Id).Column("rent_item_id");
            Map(equipment => equipment.Title).Column("title");
            Map(equipment => equipment.Count).Column("count");
            Map(equipment => equipment.IsArchival).Column("deleted");
        }
    }
}
