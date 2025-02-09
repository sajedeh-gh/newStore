using newStore.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEditProductForAdminDto request);
    }
}
