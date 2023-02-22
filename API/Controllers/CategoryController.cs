using API.Service.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public async Task<ActionResult<Category>> GetCategoryes()
        {
            var result = await _category.GetCategoryes();
            return Ok(result);
        }

    }
}
