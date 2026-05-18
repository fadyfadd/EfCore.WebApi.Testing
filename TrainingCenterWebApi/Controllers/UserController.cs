using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainingCenterWebApi.Controllers
{

    public class UserController : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("User controller is working!");
        }

    }
}