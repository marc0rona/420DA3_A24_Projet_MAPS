using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Presentation;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Classe de service général pour le login utilisateur
/// </summary>
internal class LoginService {
    private WsysApplication parentApp;
    private LoginWindow loginWindow;
    private RoleSelectionWindow roleSelectionWindow;

    /// <summary>
    /// L'utilisateur connecté ou null si aucun utilisateur n'est connecté.
    /// </summary>
    public User? LoggedInUser { get; private set; }
    /// <summary>
    /// Le role de l'utilisateur connecté, celui sélectionné si l'utilisateur 
    /// en possède plusieurs ou null si aucun utilisateur n'est connecté.
    /// </summary>
    public Role? LoggedInUserRole { get; private set; }

    public LoginService(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.loginWindow = new LoginWindow(parentApp);
        this.roleSelectionWindow = new RoleSelectionWindow(parentApp);
    }

    /// <summary>
    /// Requière qu'un utilisateur soit connecté.
    /// </summary>
    /// <remarks>
    /// Ouvre la fenêtre de connexion si aucun utilisateur n'est connecté.
    /// Si l'utilisateur ne se connecte pas correctement, termine l'application.
    /// </remarks>
    public void RequireLoggedInUser() {
        if (this.LoggedInUser == null) {
            DialogResult loginResult = this.loginWindow.ShowLoginWindow();
            if (loginResult != DialogResult.OK) {
                Application.Exit();
            }
        }
    }

    /// <summary>
    /// Tente de connecter un utilisateur avec un nom d'utilisateur et un mot de passe.
    /// </summary>
    /// <remarks>
    /// Si l'utilisateur possède plusieurs rôles, une fenêtre de sélection de rôle est affichée.<br/>
    /// Si l'utilisateur s'est connecté avec succès, l'utilisateur connecté et son rôle
    /// sont enregistrés dans les propriétés <see cref="LoggedInUser"/> et <see cref="LoggedInUserRole"/>.
    /// </remarks>
    /// <param name="username">Le nom d'utilisateur.</param>
    /// <param name="password">Le mot de passe non-encrypté.</param>
    /// <exception cref="UserNotFoundException">Si aucun utilisateur n'existe pour le nom d'utilisateur reçu.</exception>
    /// <exception cref="InvalidPasswordException">Si le mot de passe reçu ne concorde pas avec celui de l'utilisateur.</exception>
    /// <exception cref="Exception"></exception>
    public void TryLogin(string username, string password) {
        User? user = this.parentApp.UserService.GetUserByUsername(username) ?? throw new UserNotFoundException($"Nom d'utilisateur [{username}] invalide.");
        if (!this.parentApp.PasswordService.ValidatePassword(password, user.PasswordHash)) {
            throw new InvalidPasswordException("Mot de passe invalide.");
        }
        if (user.Roles.Count <= 0) {
            // Utilisateur n'a pas de rôle
            throw new Exception("Aucun rôle associé à cet utilisateur.");

        } else if (user.Roles.Count > 1) {
            // Utilisateur a plusieurs rôles
            DialogResult result = this.roleSelectionWindow.OpenForUser(user);
            this.LoggedInUserRole = result != DialogResult.OK
                ? throw new Exception("Impossible de continuer, processus de sélection de rôle interrompu anormalement.")
                : this.roleSelectionWindow.SelectedRole;

        } else {
            // Utilisateur a un seul rôle
            this.LoggedInUserRole = user.Roles[0];

        }
        this.LoggedInUser = user;
    }

    /// <summary>
    /// Déconnecte l'utilisateur connecté. Réinitialise à null 
    /// les propriétés <see cref="LoggedInUser"/> et <see cref="LoggedInUserRole"/>.
    /// </summary>
    public void Logout() {
        this.LoggedInUser = null;
        this.LoggedInUserRole = null;
    }
}
