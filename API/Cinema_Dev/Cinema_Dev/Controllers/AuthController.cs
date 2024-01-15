using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //summary
        //1 post - ValidateUserWithPass
        //2 post - ManageUserDetails
        //3 post - FetchUserDetail
        //
        [HttpPost("validateUserWithPass")]
        public ActionResult ValidateUserWithPass(int id)
        {
            try
            {
                return Ok("ValidateUserWithPass Api response {id}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("manageUserDetails")]
        public ActionResult ManageUserDetails()
        {
            try
            {
                return Ok("manageUserDetails Api response");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("fetchUserDetail")]
        public ActionResult FetchUserDetail()
        {
            try
            {
                return Ok("FetchUserDetail Api response");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
