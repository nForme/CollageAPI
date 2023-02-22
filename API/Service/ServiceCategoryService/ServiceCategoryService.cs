using Microsoft.EntityFrameworkCore;

namespace API.Service.ServiceCategoryService
{
    public class ServiceCategoryService : IServiceCategory
    {
        private readonly BeautySalonBaseKazantsevContext _context;

        public ServiceCategoryService(BeautySalonBaseKazantsevContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceCategory>> GetServiceCategories()
        {
            var ServiceCategories = await _context.ServiceCategory
                .Include(c => c.Service)
                .Include(c=>c.Category)
                .ToListAsync();
            return ServiceCategories;
        }
    }
}
