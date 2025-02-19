﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newStore.Domain.Entities.Commons;
using newStore.Domain.Entities.Orders;

namespace newStore.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public ICollection<UserInRole > UserInRoles { get; set; }

    }
}
