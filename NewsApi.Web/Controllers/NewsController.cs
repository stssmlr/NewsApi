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
        private readonly ITemplateService<News> _newsService;

        public NewsController(ITemplateService<News> newsService)
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
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _newsService.Delete(Id);
            return Ok();
        }
        /*[HttpDelete("Delete")]
        public async Task<IActionResult> Delete(News n)
        {
            var news = await _newsService.Delete(n);
            return Ok(news);
        }*/
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(News n)
        {
            await _newsService.Update(n);
            return Ok();
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(News model)
        {
            await _newsService.Insert(model);
            return Ok();
        }
    }
}