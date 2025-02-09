namespace newStore.Application.Services.Users.Commands.EditUser
{
    public class RequestEditProductForAdminDto
    {
        public long UserId { get; set; }
        public string Fullname { get; set; }

        public string Email { get; set; }
    }
}
