namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un utilisateur de l'application.
/// </summary>
public class User {
    /// <summary>
    /// Longueur minimum du nom d'utilisateur, en caractères
    /// </summary>
    public const int USERNAME_MIN_LENGTH = 4;
    /// <summary>
    /// Longueur maximum du nom d'utilisateur, en caractères
    /// </summary>
    public const int USERNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximum du mot de passe encrypté, en caractères
    /// </summary>
    public const int PASSWORDHASH_MAX_LENGTH = 128;
    /// <summary>
    /// Longueur minimum du mot de passe non-encrypté, en caractères
    /// </summary>
    public const int PASSWORD_MIN_LENGTH = 8;
    /// <summary>
    /// Longueur maximum du mot de passe non-encrypté, en caractères
    /// </summary>
    public const int PASSWORD_MAX_LENGTH = 32;

    // backing fields
    private int id;
    private string username = null!;
    private string passwordHash = null!;

    #region Propriétés de données

    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }
    public string Username {
        get { return this.username; }
        set {
            if (!ValidateUsername(value)) {
                throw new ArgumentOutOfRangeException("Username", $"Username length must be greater than or equal to {USERNAME_MIN_LENGTH} characters and lower than or equal to {USERNAME_MAX_LENGTH} characters.");
            }
            this.username = value;
        }
    }
    public string PasswordHash {
        get { return this.passwordHash; }
        set {
            if (!ValidatePasswordHash(value)) {
                throw new ArgumentOutOfRangeException("PasswordHash", $"PasswordHash length must be lower than or equal to {PASSWORDHASH_MAX_LENGTH} characters.");
            }
            this.passwordHash = value;
        }
    }
    public int? EmployeeWarehouseId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    #endregion


    #region Propriétés de navigation

    /// <summary>
    /// Liste des rôles de l'utilisateur.
    /// </summary>
    public virtual List<Role> Roles { get; set; } = new List<Role>();
    /// <summary>
    /// Liste des ordres d'expédition créés par l'utilisateur (pour employés de bureau et administrateurs).
    /// </summary>
    public virtual List<ShippingOrder> CreatedShippingOrders { get; set; } = new List<ShippingOrder>();
    /// <summary>
    /// Liste des ordres d'expédition complétés par l'utilisateur (pour employés d'entrepôt).
    /// </summary>
    public virtual List<ShippingOrder> FulfilledShippingOrders { get; set; } = new List<ShippingOrder>();
    /// <summary>
    /// L'entrepôt de travail de l'employé d'entrepôt ou <see langword="null"/> pour les autres utilisateurs.
    /// </summary>
    public virtual Warehouse? EmployeeWarehouse { get; set; }

    #endregion

    /// <summary>
    /// Constructeur orienté création utilisateur
    /// </summary>
    /// <param name="username">Le nom d'utilisateur</param>
    /// <param name="passwordHash">Le mot de passe encrypté</param>
    /// <param name="employeeWarehouseId">L'id de l'entrepôt où travaille l'employé de bureau ou <see langword="null"/>.</param>
    public User(string username, string passwordHash, int? employeeWarehouseId = null) {
        this.Username = username;
        this.PasswordHash = passwordHash;
        this.EmployeeWarehouseId = employeeWarehouseId;
    }

    /// <summary>
    /// Constructeur orienté entity framework
    /// </summary>
    /// <param name="id">L'identifiant de l'utilisateur.</param>
    /// <param name="username">Le nom d'utilisateur.</param>
    /// <param name="passwordHash">Le mot de passe encrypté.</param>
    /// <param name="employeeWarehouseId">L'id de l'entrepôt où travaille l'employé de bureau ou <see langword="null"/>.</param>
    /// <param name="dateCreated">La date de création de l'utilisateur dans la base de données.</param>
    /// <param name="dateModified">La date de dernière modification de l'utilisateur dans la base de données.</param>
    /// <param name="dateDeleted">La date de suppression de l'utilisateur dans la base de données.</param>
    /// <param name="rowVersion">Le numéro de version anti-concurrence de l'entrée dans la base de donnée.</param>
    protected User(int id,
        string username,
        string passwordHash,
        int? employeeWarehouseId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(username, passwordHash, employeeWarehouseId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    #region Méthodes

    /// <summary>
    /// Méthode de validation d'ID
    /// </summary>
    /// <param name="id">Le numéro d'ID à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateId(int id) {
        return id >= 0;
    }

    /// <summary>
    /// Méthode de validation du nom d'utilisateur
    /// </summary>
    /// <param name="username">Le nom d'utilisateur à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateUsername(string username) {
        return username.Length >= USERNAME_MIN_LENGTH
            && username.Length <= USERNAME_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de validation du mot de passe encrypté
    /// </summary>
    /// <param name="passwordHash">Le mot de passe encrypté à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidatePasswordHash(string passwordHash) {
        return passwordHash.Length <= PASSWORDHASH_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de validation du mot de passe non-encrypté
    /// </summary>
    /// <param name="password">Le mot de passe non-encrypté à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidatePassword(string password) {
        return password.Length >= PASSWORD_MIN_LENGTH
            && password.Length <= PASSWORD_MAX_LENGTH;
    }

    /// <summary>
    /// Retourne un booléen indiquant si l'utilisateur est un administrateur.
    /// </summary>
    /// <returns><see langword="true"/> si l'utilisateur possède le rôle administrateur, <see langword="false"/> sinon.</returns>
    public bool IsAdministrator() {
        return this.Roles.Any(role => {
            return role.Id == Role.ADMIN_ROLE_ID;
        });
    }

    /// <summary>
    /// Retourne un booléen indiquant si l'utilisateur est un employé de bureau.
    /// </summary>
    /// <returns><see langword="true"/> si l'utilisateur possède le rôle d'employé de bureau, <see langword="false"/> sinon.</returns>
    public bool IsOfficeEmployee() {
        return this.Roles.Any(role => {
            return role.Id == Role.OFFICE_EMPLOYEE_ROLE_ID;
        });
    }

    /// <summary>
    /// Retourne un booléen indiquant si l'utilisateur est un employé d'entrepôt.
    /// </summary>
    /// <returns><see langword="true"/> si l'utilisateur possède le rôle d'employé d'entrepôt, <see langword="false"/> sinon.</returns>
    public bool IsWarehouseEmployee() {
        return this.Roles.Any(role => {
            return role.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID;
        });
    }

    /// <summary>
    /// Override de la méthode <see cref="object.ToString"/> pour affichage des utilisateurs
    /// dans des ListBox ou ComboBox.
    /// </summary>
    /// <returns>Un string décrivant l'utilisateur.</returns>
    public override string ToString() {
        List<string> rolesAbbrev = new List<string>();
        if (this.IsAdministrator()) {
            rolesAbbrev.Add("Adm");
        }
        if (this.IsOfficeEmployee()) {
            rolesAbbrev.Add("OffE");
        }
        if (this.IsWarehouseEmployee()) {
            rolesAbbrev.Add("WhE");
        }
        return $"#{this.Id} - {this.Username} ({string.Join(", ", rolesAbbrev.ToArray())})";
    }

    #endregion

}
