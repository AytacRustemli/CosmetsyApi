using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        [HttpGet("getall")]
        public List<Blog> GetAll()
        {
            return _blogManager.GetAllBlog();
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var blog = _blogManager.GetBlogById(id);
            return Ok(new { status = 200, message = blog });
        }


        [HttpPost("add")]
        public object AddBlog(Blog blog)
        {
            _blogManager.Add(blog);
            return Ok("Blog added");
        }

        [HttpPut("update")]
        public IActionResult UpdateCategory(Blog blog)
        {
            _blogManager.Update(blog);
            return Ok(new { status = 200, message = blog });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteCategory(Blog blog)
        {
            _blogManager.Remove(blog);
            return Ok("Melumat ugurla silindi.");
        }
    }
}
