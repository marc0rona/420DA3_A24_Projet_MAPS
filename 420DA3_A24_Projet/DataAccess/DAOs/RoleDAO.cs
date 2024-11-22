using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class RoleDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="context"></param>
    public RoleDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAll(bool includeDeleted = false) {
        return this.context.Roles
            .Where(role => includeDeleted || role.DateDeleted == null)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        return this.context.Roles
            .Where(role => role.Id == id && (includeDeleted || role.DateDeleted == null))
            .Include(role => role.Users)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByRoleName(string roleName, bool includeDeleted = false) {
        return this.context.Roles
            .Where(role => role.Name == roleName && (includeDeleted || role.DateDeleted == null))
            .Include(role => role.Users)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> Search(string criterion, bool includeDeleted = false) {
        return this.context.Roles
            .Where(role => (
                role.Id.ToString().Contains(criterion)
                || role.Name.ToLower().Contains(criterion.ToLower())
                || role.Description.ToLower().Contains(criterion.ToLower())
            ) && (includeDeleted || role.DateDeleted == null))
            .Include(user => user.Users)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Create(Role role) {
        _ = this.context.Roles.Add(role);
        _ = this.context.SaveChanges();
        return role;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Update(Role role) {
        role.DateModified = DateTime.Now;
        _ = this.context.Roles.Update(role);
        _ = this.context.SaveChanges();
        return role;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role Delete(Role role, bool softDeletes = true) {
        if (softDeletes) {
            role.DateDeleted = DateTime.Now;
            _ = this.context.Roles.Update(role);

        } else {
            _ = this.context.Roles.Remove(role);
        }
        _ = this.context.SaveChanges();
        return role;
    }


}
