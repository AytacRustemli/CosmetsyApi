using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotanicalController : ControllerBase
    {
        private readonly IBotanicalManager _botanicalManager;

        public BotanicalController(IBotanicalManager botanicalManager)
        {
            _botanicalManager = botanicalManager;
        }


        [HttpGet("getall")]
        public List<Botanical> GetAll()
        {
            return _botanicalManager.GetAllBotanical();
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var botanical = _botanicalManager.GetBotanicalById(id);
            return Ok(new { status = 200, message = botanical });
        }


        [HttpPost("add")]
        public object AddBotanical(Botanical botanical)
        {
            _botanicalManager.Add(botanical);
            return Ok("Botanical added");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateBotanical(Botanical botanical, int id)
        {
            _botanicalManager.Update(botanical, id);
            return Ok(new { status = 200, message = "Mehsul yenilendi." });
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> DeleteBotanical(Botanical botanical, int id)
        {
            _botanicalManager.Remove(botanical, id);
            return Ok("Melumat ugurla silindi.");
        }
    }
}
