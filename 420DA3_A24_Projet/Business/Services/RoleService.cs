using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service class for managing <see cref="Role"/> entities.
/// </summary>
internal class RoleService {

    private readonly WsysApplication parentApp;
    private readonly RoleDAO dao;
    private readonly RoleView view;

    /// <summary>
    /// <see cref="RoleService"/> constructor.
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public RoleService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }


    /// <summary>
    /// Opens the <see cref="RoleView">role management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public Role? OpenManagementWindowForCreation() {
        try {
            Role newRole = (Role) FormatterServices.GetUninitializedObject(typeof(Role));
            DialogResult result = this.view.OpenForCreation(newRole);
            return result == DialogResult.OK
                ? this.view.CurrentEntityInstance
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="RoleView">role management window</see> in edition mode
    /// for the given <paramref name="role"/>.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(Role role) {
        try {
            DialogResult result = this.view.OpenForModification(role);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="RoleView">role management window</see> in visualization mode
    /// for the given <paramref name="role"/>.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role OpenManagementWindowForVisualization(Role role) {
        try {
            _ = this.view.OpenForDetailsView(role);
            return role;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role visualization mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="RoleView">role management window</see> in deletion mode
    /// for the given <paramref name="role"/>.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(Role role) {
        try {
            DialogResult result = this.view.OpenForDeletion(role);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role deletion mode.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="Role"/> that exist in the data source.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAllRoles(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing roles.", ex);
        }
    }

    /// <summary>
    /// Returns the <see cref="Role"/> that matches the given <paramref name="id"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a role by its Id.", ex);
        }
    }

    /// <summary>
    /// Returns the <see cref="User"/> that matches the given <paramref name="roleName"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByName(string roleName, bool includeDeleted = false) {
        try {
            return this.dao.GetByRoleName(roleName, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a role by its name.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="Role"/> that match the given <paramref name="criterion"/> in the data source.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> SearchRoles(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search existing roles.", ex);
        }
    }

    /// <summary>
    /// Inserts a <see cref="Role"/> in the data source.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role CreateRole(Role role) {
        try {
            return this.dao.Create(role);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new role in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="Role"/> in the data source.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role UpdateRole(Role role) {
        try {
            return this.dao.Update(role);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a role in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="Role"/> in the data source.
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role DeleteRole(Role role, bool softDeletes = true) {
        try {
            return this.dao.Delete(role, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a role from the database.", ex);
        }
    }
}
