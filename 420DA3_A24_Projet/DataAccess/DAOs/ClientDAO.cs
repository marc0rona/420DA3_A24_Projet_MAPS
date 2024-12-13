using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class ClientDAO {

    private readonly AppDbContext context;

    /// <param name="context"></param>
    public ClientDAO(AppDbContext context) {
        this.context = context;
    }

    public List<Client> GetAll(bool includeDeleted = false) {
        return this.context.Clients
            .Where(client => includeDeleted || client.DateDeleted == null)
            .ToList();
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Client? GetById(int id, bool includeDeleted = false) {
        return this.context.Clients
            .Where(client => client.Id == id && (includeDeleted || client.DateDeleted == null))
            .Include(client => client.Products)
            .Include(client => client.ShippingOrders)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="clientName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Client? GetByClientName(string clientName, bool includeDeleted = false) {
        return this.context.Clients
            .Where(client => client.ClientName == clientName && (includeDeleted || client.DateDeleted == null))
            .Include(client => client.Products)
            .Include(client => client.ShippingOrders)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Client> Search(string criterion, bool includeDeleted = false) {
        return this.context.Clients
            .Where(client => (
                client.Id.ToString().Contains(criterion)
                || client.ClientName.ToLower().Contains(criterion.ToLower())
            ) && (includeDeleted || client.DateDeleted == null))
            .Include(client => client.Products)
            .Include(client => client.ShippingOrders)
            .ToList();
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client Create(Client client) {
        _ = this.context.Clients.Add(client);
        _ = this.context.SaveChanges();
        return client;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client Update(Client client) {
        client.DateModified = DateTime.Now;
        _ = this.context.Clients.Update(client);
        _ = this.context.SaveChanges();
        return client;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Client Delete(Client client, bool softDeletes = true) {
        if (softDeletes) {
            client.DateDeleted = DateTime.Now;
            _ = this.context.Clients.Update(client);

        } else {
            _ = this.context.Clients.Remove(client);
        }
        _ = this.context.SaveChanges();
        return client;
    }


}
