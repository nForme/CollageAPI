namespace API.Service.ClientService.ClientService
{
    public interface IClient
    {
        Task<List<Client>> GetClients();
        Task<Client> GetClient(int id);
    }
}
