using Data.Model;
using Data.Repository.Repository.UserRepo;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> UserLoginAsync([FromBody] LoginModel model)
        {
            if (model.Username == null || model.Password == null)
            {
                return Content("Invalid UserName or Password");
            }

            var user = userRepository.GetAllUsersAsync().GetAwaiter().GetResult().FirstOrDefault(x => x.EmailId == model.Username);

            if (user != null && PasswordHelper.VerifyPassword(model.Password, user.Password))
            {
                JwtTokenHelper jwtToken = new JwtTokenHelper();
                return Content(jwtToken.CreateJwtToken(user));
            }

            return Content("Invalid UserName or Password");
        }
    }
}
