using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandManager _brandManager;

        public BrandController(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }

        [HttpGet("getall")]
        public List<Brand> GetAll()
        {
            return _brandManager.GetAllBrand();
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var brand = _brandManager.GetBrandById(id);
            return Ok(new { status = 200, message = brand });
        }


        [HttpPost("add")]
        public object AddBrand(Brand brand)
        {
            _brandManager.Add(brand);
            return Ok("Brand added");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateBrand(Brand brand, int id)
        {
            _brandManager.Update(brand, id);
            return Ok(new { status = 200, message = "Mehsul yenilendi." });
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> DeleteBrand(Brand brand, int id)
        {
            _brandManager.Remove(brand, id);
            return Ok("Melumat ugurla silindi.");
        }
    }
}
