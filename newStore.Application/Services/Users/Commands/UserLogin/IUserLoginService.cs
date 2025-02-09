using newStore.Common;
using newStore.Common.Dto;
using newStore.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newStore.Application.Services.Users.Commands.UserLogin;

namespace newStore.Application.Services.Users.Commands.UserLogin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string Username, string Password);
    }
}
