using API.Service.ServiceCategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryController : ControllerBase
    {
        private readonly IServiceCategory _serviceCategory;

        public ServiceCategoryController(IServiceCategory serviceCategory)
        {
            _serviceCategory = serviceCategory;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceCategory>> GetServiceCategories()
        {
            var result = await _serviceCategory.GetServiceCategories();
            return Ok(result);
        }
    }
}
