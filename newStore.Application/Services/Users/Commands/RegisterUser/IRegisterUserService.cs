using newStore.Common;
using newStore.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Users.Commands.RgegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }



}
