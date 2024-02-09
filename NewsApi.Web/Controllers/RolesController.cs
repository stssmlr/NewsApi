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
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _roleService;

        public RolesController(IRolesService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _roleService.GetAll();
            return Ok(users);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> GetById(int Id)
        {
            var users = await _roleService.Get(Id);
            return Ok(users);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(RolesDto model)
        {
            await _roleService.Insert(model);
            return Ok();
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update(RolesUpdateDto model)
        {
            await _roleService.Update(model);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _roleService.Delete(Id);
            return Ok();
        }
    }
}