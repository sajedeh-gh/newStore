﻿using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;
using newStore.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using newStore.Application.Interfaces.Contexts;
using newStore.Common.Dto;
using newStore.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Orders.Commands.AddNewOrder
{
    public interface IAddNewOrderService
    {
        ResultDto Execute(RequestAddNewOrderSericeDto request);
    }

    public class AddNewOrderService : IAddNewOrderService
    {
        private readonly IDataBaseContext _context;
        public AddNewOrderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddNewOrderSericeDto request)
        {
            var user = _context.Users.Find(request.UserId);
            var requestPay = _context.RequestPays.Find(request.RequestPayId);
            var cart = _context.Carts.Include(p => p.CartItems)
                .ThenInclude(p => p.Product)
                .Where(p => p.Id == request.CartId).FirstOrDefault();

            requestPay.IsPay = true;
            requestPay.PayDate = DateTime.Now;
            requestPay.RefId = request.RefId;
            requestPay.Authority = requestPay.Authority;
            cart.Finished = true;

            Order order = new Order()
            {
                Address = "",
                OrderState = OrderState.Processing,
                RequestPay = requestPay,
                User = user,

            };
            _context.Orders.Add(order);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart.CartItems)
            {

                OrderDetail orderDetail = new OrderDetail()
                {
                    Count = item.Count,
                    Order = order,
                    Price = item.Product.Price,
                    Product = item.Product,
                };
                orderDetails.Add(orderDetail);
            }


            _context.OrderDetails.AddRange(orderDetails);

            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "",
            };
        }
    }
    public class RequestAddNewOrderSericeDto
    {
        public long CartId { get; set; }
        public long RequestPayId { get; set; }
        public long UserId { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; } = 0;

    }
}
