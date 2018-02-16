using FluentNHibernate.Mapping;
using Iskra.Domain.Models;

namespace Iskra.Domain.Models
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Schema("public");
            Table("users");
            Id(user => user.Id).Column("user_id");
            Map(user => user.Birthday).Column("birthdate");
            Map(user => user.IsDeleted).Column("deleted");
            Map(user => user.Name).Column("fio");
            Map(user => user.Phone).Column("phone");
            Map(user => user.Password).Column("password");
            References(user => user.UserType).Column("user_type_id");
        }
    }
}
