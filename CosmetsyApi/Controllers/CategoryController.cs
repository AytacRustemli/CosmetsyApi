using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getall")]
        public List<Category> GetAll()
        {
            return _categoryManager.GetAllCategories();
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryManager.GetCategoryById(id);
            return Ok(new { status = 200, message = category });
        }


        [HttpPost("add")]
        public object AddCategory(Category category)
        {
            _categoryManager.Add(category);
            return Ok("Category added");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateCategory(Category category, int id)
        {
            _categoryManager.Update(category, id);
            return Ok(new { status = 200, message = "Mehsul yenilendi." });
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> DeleteCategory(Category category, int id)
        {
            _categoryManager.Remove(category, id);
            return Ok("Melumat ugurla silindi.");
        }

    }
}
