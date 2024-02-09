using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interface;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _userService;

        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> GetById(int Id)
        {
            var users = await _userService.Get(Id);
            return Ok(users);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(UsersDto model)
        {
            await _userService.Insert(model);
            return Ok();
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update(UsersUpdateDto model)
        {
            await _userService.Update(model);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _userService.Delete(Id);
            return Ok();
        }
    }
}