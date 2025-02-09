
using System.Collections.Generic;
using newStore.Domain.Entities.Commons;

namespace newStore.Domain.Entities.Users
{
    public class Role: BaseEntity
    {
        public string  Name { get; set; }
        public ICollection<UserInRole > UserInRoles { get; set; }
    }
}
