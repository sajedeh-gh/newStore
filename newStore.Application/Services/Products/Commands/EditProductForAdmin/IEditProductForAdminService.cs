using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Users.Commands.EditProductForAdmin
{
    public interface IEditProductForAdminService
    {
        ResultDto Execute(RequestEditProductForAdminDto request);
    }
}
