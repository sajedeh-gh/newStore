using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Carts
{
    public interface ICartService
    {
        ResultDto AddToCart(long ProductId, Guid BrowserId);
        ResultDto RemoveFromCart(long ProductId, Guid BrowserId);
        ResultDto<CartDto> GetMyCart(Guid BrowserId,long? UserId);
        ResultDto Add(long CartItemId);
        ResultDto LowOff(long CartItemId);
    }
}
