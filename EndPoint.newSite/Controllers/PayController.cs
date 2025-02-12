using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using newStore.Application.Services.Carts;
using newStore.Application.Services.Fainances.Commands.AddRequestPay;
using newStore.Domain.Entities.Carts;
using EndPoint.newSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using newStore.Application.Services.Carts;
using newStore.Application.Services.Fainances.Commands.AddRequestPay;
using Newtonsoft.Json;
using NuGet.Configuration;

namespace EndPoint.newSite.Controllers
{
    [Authorize]
    public class PayController : Controller
    {
        private readonly IAddRequestPayService _addRequestPayService;
        private readonly ICartService _cartService;
        private readonly CookiesManeger _cookiesManeger;
        


        public PayController(IAddRequestPayService addRequestPayService
            , ICartService cartService
    

             )
        {
            _addRequestPayService = addRequestPayService;
            _cartService = cartService;
            _cookiesManeger = new CookiesManeger();

        }
        public IActionResult Index()
        {
            long? UserId = ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), UserId);
            if (cart.Data.SumAmount > 0)
            {
                var requestPay = _addRequestPayService.Execute(cart.Data.SumAmount, UserId.Value);
                // ارسال در گاه پرداخت

            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }
            return View();

        }

        
    }


}
