using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Common.Queries.GetMenuItem
{
    public interface IGetMenuItemService
    {
        ResultDto<List<MenuItemDto>> Execute();   
    }
}
