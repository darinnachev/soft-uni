using HomeWork.Models.Identity;
using HomeWork.Services.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IIdentityService identity;
        private readonly ICurrentUserService currentUser;

        public UsersController(IIdentityService identity,
            ICurrentUserService currentUser)
        {
            this.identity = identity;
            this.currentUser = currentUser;
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }              

        [HttpPost("authenticate")]
        public async Task<ActionResult<LoginOutputModel>> Authenticate([FromForm] UserInputModel input)
        {
            var result = await this.identity.Login(input);

            if (!result.Succeeded)
            {
                return BadRequest(result);
            }

            var user = result.Data;

            return Ok (new LoginOutputModel(user.Token, 0) );
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet("registraciq")]
        public async Task<ActionResult> Registraciq(CreateUserInputModel input)
        {
            var result = await this.identity.Register(input);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            var user = result.Data;

            return Ok();
        }
    }
}
