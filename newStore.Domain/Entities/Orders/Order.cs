﻿using newStore.Domain.Entities.Commons;
using newStore.Domain.Entities.Finances;
using newStore.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {

        public virtual User User { get; set; }
        public long UserId { get; set; }

        public virtual RequestPay RequestPay { get; set; }
        public long RequestPayId { get; set; }

        public OrderState OrderState { get; set; }

        public string Address { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
     }

}
