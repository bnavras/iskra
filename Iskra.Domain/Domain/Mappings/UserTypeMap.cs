using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class UserTypeMap : ClassMap<UserType>
    {
        public UserTypeMap()
        {
            Schema("public");
            Table("user_type");
            Id(userType => userType.Id).Column("user_type_id");
            Map(userType => userType.Title).Column("title");

            HasMany(user => user.Users).KeyColumn("user_type_id")
                .Inverse()
                .Cascade.All();
        }
    }
}
