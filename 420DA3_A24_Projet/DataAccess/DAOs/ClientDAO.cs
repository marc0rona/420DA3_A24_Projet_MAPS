using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class ClientDAO {

    private readonly AppDbContext context;

    /// <param name="context"></param>
    public ClientDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF : documenter
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
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="username"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public User? GetByUsername(string username, bool includeDeleted = false) {
        return this.context.Users
            .Where(user => user.Username == username && (includeDeleted || user.DateDeleted == null))
            .Include(user => user.Roles)
            .Include(user => user.EmployeeWarehouse)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<User> Search(string criterion, bool includeDeleted = false) {
        return this.context.Users
            .Where(user => (
                user.Id.ToString().Contains(criterion)
                || user.Username.ToLower().Contains(criterion.ToLower())
            ) && (includeDeleted || user.DateDeleted == null))
            .Include(user => user.Roles)
            .Include(user => user.EmployeeWarehouse)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User Create(User user) {
        _ = this.context.Users.Add(user);
        _ = this.context.SaveChanges();
        return user;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User Update(User user) {
        user.DateModified = DateTime.Now;
        _ = this.context.Users.Update(user);
        _ = this.context.SaveChanges();
        return user;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public User Delete(User user, bool softDeletes = true) {
        if (softDeletes) {
            user.DateDeleted = DateTime.Now;
            _ = this.context.Users.Update(user);

        } else {
            _ = this.context.Users.Remove(user);
        }
        _ = this.context.SaveChanges();
        return user;
    }


}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ClientDAO {
}
