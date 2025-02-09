using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using newStore.Common.Dto;
using newStore.Domain.Entities.Users;

namespace newStore.Application.Services.Products.Commands.DeleteProductForAdmin
{
    public interface IDeleteProductForAdminService
    {
        ResultDto Execute(long id);
    }
}
