namespace _420DA3_A24_Projet.Business.Domain;
public class User {
    public const int UsernameMaxLength = 64;
    public const int PasswordHashMaxLength = 128;

    // Propriétés de données
    public int Id { get; set; }
    public int? EmployeeWarehouseId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    // propriétés de navigation
    public virtual List<Role> Roles { get; set; } = new List<Role>();

    // TODO: @PROF nav props for
    // - created shipping orders
    // - fulfilled shipping orders
    // - Employee warehouse

    public User(string username, string passwordHash, int? employeeWarehouseId = null) {
        this.Username = username;
        this.PasswordHash = passwordHash;
        this.EmployeeWarehouseId = employeeWarehouseId;
    }

    protected User(int id,
        string username,
        string passwordHash,
        int? employeeWarehouseId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion) : this(username, passwordHash, employeeWarehouseId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

}
