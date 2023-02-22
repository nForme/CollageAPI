using Microsoft.EntityFrameworkCore;

namespace API.Service.ClientService.ClientService
{
    public class ClientService : IClient
    {
        private readonly BeautySalonBaseKazantsevContext _context;

        public ClientService(BeautySalonBaseKazantsevContext context)
        {
            _context = context;
        }

        public async Task<Client> CreateClient(Client client)
        {
            _context.Client.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> GetClient(int id)
        {
            var Client = await _context.Client.FindAsync(id);
            if (Client == null)
                return null;
            return Client;
        }

        public async Task<List<Client>> GetClients()
        {
            var Clients = await _context.Client.ToListAsync();
            if (Clients == null)
                return null;
            return Clients;
        }
    }
}
