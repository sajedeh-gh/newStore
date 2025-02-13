using newStore.Domain.Entities.Orders;

namespace newStore.Application.Services.Orders.Queries.GetUserOrders
{
    public class GetUserOrdersDto
    {
        public long OrderId { get; set; }
        public OrderState OrderState { get; set; }
        public long RequestPayId { get; set; }
        public List<OrderDetailsDto> OrderDetails { get; set; }
    }
}
