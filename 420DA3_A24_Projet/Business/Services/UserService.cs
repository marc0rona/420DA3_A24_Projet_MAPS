using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

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
    public UserService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.userDAO = new UserDAO(context);
        this.userWindow = new UserView(parentApp);
    }


    #region METHODS

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
