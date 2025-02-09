using newStore.Common.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStore.Application.Services.Users.Commands.RemoveUser
{
    public interface IRemoveUserService
    {
        ResultDto Execute(long UserId);
    }
}
