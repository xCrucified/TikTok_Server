using business_logic.DTOs;
using business_logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TikTok_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        public readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        { 
            this._videoService = videoService;
        }
        
        [HttpGet("all")]
        public IActionResult GetAll() => Ok(this._videoService.GetAll());

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await _videoService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateVideoModel model)
        {
            _videoService.Create(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] VideoDto model)
        {
            await _videoService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _videoService.Delete(id);
            return Ok();
        }
    }
}
