using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service class for managing <see cref="User"/> entities.
/// </summary>
internal class UserService {

    private readonly UserDAO userDAO;
    private readonly UserView userWindow;

    /// <summary>
    /// <see cref="UserService"/> constructor.
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public UserService(WsysApplication parentApp, AppDbContext context) {
        this.userDAO = new UserDAO(context);
        this.userWindow = new UserView(parentApp);
    }


    #region METHODS

    /// <summary>
    /// Opens the <see cref="UserView">user management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public User? OpenManagementWindowForCreation() {
        try {
            User newUser = (User) FormatterServices.GetUninitializedObject(typeof(User));
            DialogResult result = this.userWindow.OpenForCreation(newUser);
            return result == DialogResult.OK
                ? newUser
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="UserView">user management window</see> in edition mode
    /// for the given <paramref name="user"/>.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(User user) {
        try {
            DialogResult result = this.userWindow.OpenForModification(user);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="UserView">user management window</see> in visualization mode
    /// for the given <paramref name="user"/>.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User OpenManagementWindowForVisualization(User user) {
        try {
            _ = this.userWindow.OpenForDetailsView(user);
            return user;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user visualization mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="UserView">user management window</see> in deletion mode
    /// for the given <paramref name="user"/>.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(User user) {
        try {
            DialogResult result = this.userWindow.OpenForDeletion(user);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user deletion mode.", ex);
        }
    }



    /// <summary>
    /// Returns the <see cref="User"/> that matches the given <paramref name="id"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public User? GetUserById(int id) {
        try {
            return this.userDAO.GetById(id);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a user by its ID.", ex);
        }
    }

    /// <summary>
    /// Returns the <see cref="User"/> that matches the given <paramref name="username"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public User? GetUserByUsername(string username) {
        try {
            return this.userDAO.GetByUsername(username);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a user by its username.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="User"/> that match the given <paramref name="criterion"/> in the data source.
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<User> SearchUsers(string criterion) {
        try {
            return this.userDAO.Search(criterion);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search users.", ex);
        }
    }

    /// <summary>
    /// Inserts a <see cref="User"/> in the data source.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User CreateUserInDatabase(User user) {
        try {
            return this.userDAO.Create(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new user in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="User"/> in the data source.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User UpdateUserInDatabase(User user) {
        try {
            return this.userDAO.Update(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a new user in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="User"/> from the data source.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User DeleteUserFromDatabase(User user) {
        try {
            return this.userDAO.Delete(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a new user in the database.", ex);
        }
    }

    #endregion

}
