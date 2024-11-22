namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un rôle-utilisateur de l'application.
/// </summary>
public class Role {
    /// <summary>
    /// Identifiant du rôle administrateur.
    /// </summary>
    public const int ADMIN_ROLE_ID = 1;
    /// <summary>
    /// Identifiant du rôle employé de bureau.
    /// </summary>
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    /// <summary>
    /// Identifiant du rôle employé d'entrepôt.
    /// </summary>
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;
    /// <summary>
    /// Longueur maximale du nom du rôle.
    /// </summary>
    public const int NAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale de la description du rôle.
    /// </summary>
    public const int DESCRIPTION_MAX_LENGTH = 255;

    private int id;
    private string name = null!;
    private string description = null!;


    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }
    public string Name {
        get { return this.name; }
        set {
            if (!ValidateName(value)) {
                throw new ArgumentOutOfRangeException("Name", $"Name length must be lower than or equal to {NAME_MAX_LENGTH} characters.");
            }
            this.name = value;
        }
    }
    public string Description {
        get { return this.description; }
        set {
            if (!ValidateDescription(value)) {
                throw new ArgumentOutOfRangeException("Description", $"Description length must be lower than or equal to {DESCRIPTION_MAX_LENGTH} characters.");
            }
            this.description = value;
        }
    }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Liste des utilisateurs possédant ce rôle.
    /// </summary>
    public virtual List<User> Users { get; set; } = new List<User>();


    /// <summary>
    /// Constructeur orienté création manuelle/UI.
    /// </summary>
    /// <param name="name">Le nom du rôle.</param>
    /// <param name="description">La description du rôle.</param>
    public Role(string name, string description) {
        this.Name = name;
        this.Description = description;
    }

    /// <summary>
    /// Constructeur orienté entity framework.
    /// </summary>
    /// <param name="id">L'identifiant du rôle.</param>
    /// <param name="name">Le nom du rôle.</param>
    /// <param name="description">La description du rôle.</param>
    /// <param name="dateCreated">La date de création du rôle dans la base de données.</param>
    /// <param name="dateModified">La date de dernière modification du rôle dans la base de données.</param>
    /// <param name="dateDeleted">La date de suppression du rôle dans la base de données.</param>
    /// <param name="rowVersion">Le numéro de version anti-concurrence de l'entrée dans la base de donnée.</param>
    protected Role(int id,
        string name,
        string description,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(name, description) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    /// <summary>
    /// Méthode de validation d'identifiant de rôle.
    /// </summary>
    /// <param name="id">Le numéro d'ID à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateId(int id) {
        return id >= 0;
    }


    /// <summary>
    /// Méthode de validation de nom de rôle.
    /// </summary>
    /// <param name="name">Le nom à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateName(string name) {
        return name.Length <= NAME_MAX_LENGTH;
    }


    /// <summary>
    /// Méthode de validation de description de rôle.
    /// </summary>
    /// <param name="description">La description à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateDescription(string description) {
        return description.Length <= DESCRIPTION_MAX_LENGTH;
    }



    /// <summary>
    /// Retourne un booléen indiquant si le role est le rôle administrateur.
    /// </summary>
    /// <returns><see langword="true"/> si le rôle est le rôle administrateur, <see langword="false"/> sinon.</returns>
    public bool IsAdministratorRole() {
        return this.Id == ADMIN_ROLE_ID;
    }

    /// <summary>
    /// Retourne un booléen indiquant si le role est le rôle d'employé de bureau.
    /// </summary>
    /// <returns><see langword="true"/> si le role est le rôle d'employé de bureau, <see langword="false"/> sinon.</returns>
    public bool IsOfficeEmployeeRole() {
        return this.Id == Role.OFFICE_EMPLOYEE_ROLE_ID;
    }

    /// <summary>
    /// Retourne un booléen indiquant si le role est le rôle d'employé d'entrepot.
    /// </summary>
    /// <returns><see langword="true"/> si le role est le rôle d'employé d'entrepot, <see langword="false"/> sinon.</returns>
    public bool IsWarehouseEmployeeRole() {
        return this.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID;
    }



    /// <summary>
    /// Override de la méthode <see cref="object.ToString"/> pour affichage des rôles
    /// dans des ListBox ou ComboBox.
    /// </summary>
    /// <returns>Un string décrivant le rôle.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Name}";
    }

}
