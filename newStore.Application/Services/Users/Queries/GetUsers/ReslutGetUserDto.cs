using System.Collections.Generic;

namespace newStore.Application.Services.Users.Queries.GetUsers
{
    public class ReslutGetUserDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
