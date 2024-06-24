using FirebaseAdmin.Auth;
using FirebaseSocialLogin.API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FirebaseSocialLogin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet("protected")]
        [Authorize]
        public IActionResult GetProtectedResource()
        {
            return Ok("This is a protected resource.");
        }

        
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login(LoginReq req)
        {
            try
            {
                FirebaseToken decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(req.Token);
                string uid = decodedToken.Uid;
                // Here, you can create a session for the user or perform further actions based on the user's UID

                return Ok("User logged in successfully.");
            }
            catch (FirebaseAuthException ex)
            {
                // Token is invalid
                return Unauthorized("Invalid ID token.");
            }
            catch (Exception ex)
            {
                // Other errors
                return StatusCode(500, "Internal server error.");
            }
        }
    }
}
