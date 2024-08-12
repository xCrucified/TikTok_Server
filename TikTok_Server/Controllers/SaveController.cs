using business_logic.DTOs;
using business_logic.Interfaces;
using business_logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TikTok_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveController : ControllerBase
    {
        public readonly ISaveService _saveService;

        public SaveController(ISaveService _saveService)
        {
            this._saveService = _saveService;
        }

        [HttpGet("{id:int}")]
        
        public async Task<IActionResult> Get([FromRoute] int id) => Ok(await _saveService.Get(id));

        [HttpPost]
        public IActionResult Create([FromForm] CreateSaveModel model)
        {
            _saveService.Add(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _saveService.Remove(id);
            return Ok();
        }
    }
}
