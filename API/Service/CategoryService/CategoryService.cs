using Microsoft.EntityFrameworkCore;

namespace API.Service.CategoryService
{
    public class CategoryService : ICategory
    {
        private readonly BeautySalonBaseKazantsevContext _context;

        public CategoryService(BeautySalonBaseKazantsevContext context)
        {
            _context= context;
        }
        public async Task<List<Category>> GetCategoryes()
        {
            var Categotyes = await _context.Category.ToListAsync();
            return Categotyes;
        }
    }
}
