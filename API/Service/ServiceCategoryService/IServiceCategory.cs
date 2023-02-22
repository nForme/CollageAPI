namespace API.Service.ServiceCategoryService
{
    public interface IServiceCategory
    {
        Task<List<ServiceCategory>> GetServiceCategories();
    }
}
