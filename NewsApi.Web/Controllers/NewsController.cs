using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _newsService.GetAll();
            return Ok(news);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _newsService.Get(Id);
            return Ok(news);
        }
        [HttpDelete("DeleteById")]
        public async Task<IActionResult> DeleteById(int Id)
        {
            var news = await _newsService.DeleteById(Id);
            return Ok(news);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(News n)
        {
            var news = await _newsService.Delete(n);
            return Ok(news);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(NewsUpdateDto n)
        {
            await _newsService.Update(n);
            return Ok();
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(NewsDto model)
        {
            await _newsService.Insert(model);
            return Ok();
        }
    }
}