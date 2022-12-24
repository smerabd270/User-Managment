using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using User_Managment.Models;

namespace User_Managment.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]



    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpDelete]
        public async Task<IActionResult>Delete(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound();
            var result =await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                throw new Exception();
            }
            return Ok();
        }
    }
}
