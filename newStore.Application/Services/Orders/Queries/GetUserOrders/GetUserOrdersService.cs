using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace newStore.Application.Services.Orders.Queries.GetUserOrders
{
    public class GetUserOrdersService : IGetUserOrdersService
    {
        private readonly IDataBaseContext _context;

        public GetUserOrdersService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<GetUserOrdersDto>> Execute(long UserId)
        {
            var orders = _context.Orders
                .Include(p => p.OrderDetails)
                .ThenInclude(p => p.Product)
                .Where(p => p.UserId == UserId)
                .OrderByDescending(p => p.Id).ToList().Select(p => new GetUserOrdersDto
                {
                    OrderId = p.Id,
                    OrderState = p.OrderState,
                    RequestPayId = p.RequestPayId,
                    OrderDetails = p.OrderDetails.Select(o => new OrderDetailsDto
                    {
                        Count = o.Count,
                        OrderDetailId = o.Id,
                        Price = o.Price,
                        ProductId = o.ProductId,
                        ProductName = o.Product.Name,
                    }).ToList(),
                }).ToList();

            return new ResultDto<List<GetUserOrdersDto>>()
            {
                Data = orders,
                IsSuccess = true,
            };


        }
    }
}
