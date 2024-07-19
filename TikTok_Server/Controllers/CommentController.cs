using business_logic.DTOs;
using business_logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TikTok_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _commService;

        public CommentController(ICommentService _commService)
        {
            this._commService = _commService;
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get([FromRoute] int id) => Ok(await _commService.Get(id));

        [HttpPost]
        public IActionResult Create([FromForm] CreateCommentModel model)
        {
            _commService.Add(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _commService.Remove(id);
            return Ok();
        }
    }
}
