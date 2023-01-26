using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavinesController : ControllerBase
    {
        private readonly IDavinesManager _davinesManager;

        public DavinesController(IDavinesManager davinesManager)
        {
            _davinesManager = davinesManager;
        }

        [HttpGet("getall")]
        public List<Davines> GetAll()
        {
            return _davinesManager.GetAllDavines();
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var davines = _davinesManager.GetDavinesById(id);
            return Ok(new { status = 200, message = davines });
        }


        [HttpPost("add")]
        public object AddDavines(Davines davines)
        {
            _davinesManager.Add(davines);
            return Ok("Davines added");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateDavines(Davines davines, int id)
        {
            _davinesManager.Update(davines, id);
            return Ok(new { status = 200, message = "Mehsul yenilendi." });
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> DeleteDavines(Davines davines, int id)
        {
            _davinesManager.Remove(davines, id);
            return Ok("Melumat ugurla silindi.");
        }
    }
}
