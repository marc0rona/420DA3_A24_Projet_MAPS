using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class RoleService {

    private WsysApplication parentApp;
    private RoleDAO dao;
    private RoleView view;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAllRoles(bool includeDeleted = false) {
        return this.dao.GetAll(includeDeleted);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByName(string roleName, bool includeDeleted = false) {
        return this.dao.GetByRoleName(roleName, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> SearchRoles(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role CreateRole(Role role) {
        return this.dao.Create(role);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role UpdateRole(Role role) {
        return this.dao.Update(role);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role DeleteRole(Role role, bool softDeletes = true) {
        return this.dao.Delete(role, softDeletes);
    }
}
