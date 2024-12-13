using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Data Access Object class for <see cref="Role"/> entities.
/// </summary>
internal class RoleDAO {

    private readonly AppDbContext context;

    /// <summary>
    /// <see cref="RoleDAO"/> constructor.
    /// </summary>
    /// <param name="context"></param>
    public RoleDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Retrieves the list of every <see cref="Role"/> from the database.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAll(bool includeDeleted = false) {
        try {
            return this.context.Roles
                .Where(role => includeDeleted || role.DateDeleted == null)
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all roles from database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the <see cref="Role"/> whose <see cref="Role.Id"/> matches the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        try {
            return this.context.Roles
                .Where(role => role.Id == id && (includeDeleted || role.DateDeleted == null))
                .Include(role => role.Users)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve role Id #{id} from database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the <see cref="Role"/> whose 
    /// <see cref="Role.Name"/> matches the given <paramref name="roleName"/>.
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByRoleName(string roleName, bool includeDeleted = false) {
        try {
            return this.context.Roles
                .Where(role => role.Name == roleName && (includeDeleted || role.DateDeleted == null))
                .Include(role => role.Users)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve role names [{roleName}] from database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the list of every <see cref="Role"/> that matches a given <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.context.Roles
                .Where(role => (
                    role.Id.ToString().Contains(criterion)
                    || role.Name.ToLower().Contains(criterion.ToLower())
                    || role.Description.ToLower().Contains(criterion.ToLower())
                ) && (includeDeleted || role.DateDeleted == null))
                .Include(user => user.Users)
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search roles in database.", ex);
        }
    }

    /// <summary>
    /// Inserts a <see cref="Role"/> in the database.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Create(Role role) {
        try {
            _ = this.context.Roles.Add(role);
            _ = this.context.SaveChanges();
            return role;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create role in database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="Role"/> in the database.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Update(Role role) {
        DateTime? originalDateModified = role.DateModified;
        try {
            role.DateModified = DateTime.Now;
            _ = this.context.Roles.Update(role);
            _ = this.context.SaveChanges();
            return role;

        } catch (Exception ex) {
            // revert date modified
            role.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update role in database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="Role"/> from the database.
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role Delete(Role role, bool softDeletes = true) {
        DateTime? originalDateDelated = role.DateDeleted;
        try {
            if (softDeletes) {
                role.DateDeleted = DateTime.Now;
                _ = this.context.Roles.Update(role);

            } else {
                _ = this.context.Roles.Remove(role);
            }
            _ = this.context.SaveChanges();
            return role;

        } catch (Exception ex) {
            // revert date deleted
            role.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete role from database.", ex);
        }
    }

}
