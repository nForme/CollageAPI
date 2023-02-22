namespace API.Service.CategoryService
{
    public interface ICategory
    {
        Task<List<Category>> GetCategoryes();
    }
}
