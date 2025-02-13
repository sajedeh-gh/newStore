﻿using newStore.Domain.Entities.Commons;
using newStore.Domain.Entities.Products;

namespace newStore.Domain.Entities.Orders
{
    public class OrderDetail:BaseEntity
    {
        public virtual Order Order { get; set; }
        public long OrderId { get; set; }

        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

        public int Price { get; set; }
        public int Count { get; set; }
    }

}
