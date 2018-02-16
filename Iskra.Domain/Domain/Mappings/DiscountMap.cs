using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class DiscountMap : ClassMap<Discount>
    {
        public DiscountMap()
        {
            Schema("public");
            Table("discount");
            Id(discount => discount.Id).Column("discount_id");
            Map(discount => discount.Title).Column("title");
            Map(discount => discount.Percent).Column("percent");
            Map(discount => discount.IsArchival).Column("deleted");
        }
    }
}
