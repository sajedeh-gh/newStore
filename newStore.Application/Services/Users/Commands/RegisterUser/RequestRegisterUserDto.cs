using System.ComponentModel.DataAnnotations;

namespace newStore.Application.Services.Users.Commands.RgegisterUser
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public String Password { get; set; }
        public List<RolesInRegisterUserDto> roles { get; set; }
        
        public String RePassword { get; set; }
    }



}
