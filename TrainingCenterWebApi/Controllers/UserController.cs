using DataAccessLayer.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingCenterWebApi.Services;

namespace TrainingCenterWebApi.Controllers
{

    public class UserController : ApiBaseController
    {

        private readonly UserService userService;
     
        public UserController(UserService userService)
        {
            this.userService = userService; ;
        }

        [HttpPost("/register")]
        public async Task<ActionResult<ApplicationUserDto>> RegisterUser([FromBody]ApplicationUserDto applicationUserDto)
        {
            await userService.RegisterUser(applicationUserDto);
            return Ok(applicationUserDto);
        }

    }
}