using ProjectEweis.Services;
using Microsoft.AspNetCore.Mvc;
using TestApiJWT.Models;
using ProjectEweis.ModelView.POSTVM;

namespace ProjectEweis.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly ILoginSystem _LoginSystem;

        public loginController(ILoginSystem LoginSystem)
        {
            _LoginSystem = LoginSystem;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _LoginSystem.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync([FromBody] TokenRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _LoginSystem.GetTokenAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUser model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _LoginSystem.UpdateUser(model);

            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);

            return Ok(new {message="تم التعديل"});
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync([FromBody] AddRoleModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _LoginSystem.AddRoleAsync(model);

            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);

            return Ok(model);
        }

    }
}
