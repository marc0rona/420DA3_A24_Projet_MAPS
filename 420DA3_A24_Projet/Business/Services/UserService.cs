using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class UserService {

    private WsysApplication parentApp;
    private UserDAO userDAO;
    private UserView userWindow;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.userDAO = new UserDAO(context);
        this.userWindow = new UserView(parentApp);
    }


    #region METHODS

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <returns></returns>
    public User? OpenUserManagementWindowForCreation() {
        User newEmptyUser = (User) FormatterServices.GetUninitializedObject(typeof(User));
        DialogResult result = this.userWindow.OpenForCreation(newEmptyUser);
        return result == DialogResult.OK
            ? this.userWindow.CurrentEntityInstance
            : null;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToEdit"></param>
    /// <returns></returns>
    public User OpenUserManagementWindowForEdition(User userToEdit) {
        _ = this.userWindow.OpenForModification(userToEdit);
        return userToEdit;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToView"></param>
    /// <returns></returns>
    public User OpenUserManagementWindowForVisualization(User userToView) {
        _ = this.userWindow.OpenForDetailsView(userToView);
        return userToView;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToDelete"></param>
    /// <returns></returns>
    public User OpenUserManagementWindowForDeletion(User userToDelete) {
        _ = this.userWindow.OpenForDeletion(userToDelete);
        return userToDelete;
    }



    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public User? GetUserById(int id) {
        return this.userDAO.GetById(id);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public User? GetUserByUsername(string username) {
        return this.userDAO.GetByUsername(username);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<User> SearchUsers(string criterion) {
        return this.userDAO.Search(criterion);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User CreateUserInDatabase(User user) {
        return this.userDAO.Create(user);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User UpdateUserInDatabase(User user) {
        return this.userDAO.Update(user);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User DeleteUserFromDatabase(User user) {
        return this.userDAO.Delete(user);
    }

    #endregion

}
