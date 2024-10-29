using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class User {
    public const int USERNAME_MIN_LENGTH = 4;
    public const int USERNAME_MAX_LENGTH = 64;
    public const int PASSWORDHASH_MAX_LENGTH = 128;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 32;

    // backing fields
    private int id;
    private string username = null!;
    private string passwordHash = null!;

    // propriétés de données
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

    // Propriétés de navigation
    public virtual List<Role> Roles { get; set; } = new List<Role>();
    //public virtual List<ShippingOrder> CreatedShippingOrders { get; set; } = new List<ShippingOrder>();
    //public virtual List<ShippingOrder> FulfilledShippingOrders { get; set; } = new List<ShippingOrder>();
    //public virtual Warehouse? EmployeeWarehouse { get; set; };


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
        byte[] rowVersion)
        : this(username, passwordHash, employeeWarehouseId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    public static bool ValidateId(int id) {
        return id >= 0;
    }

    public static bool ValidateUsername(string username) {
        return username.Length >= USERNAME_MIN_LENGTH 
            && username.Length <= USERNAME_MAX_LENGTH;
    }

    public static bool ValidatePasswordHash(string passwordHash) {
        return passwordHash.Length <= PASSWORDHASH_MAX_LENGTH;
    }

    public static bool ValidatePassword(string password) {
        return password.Length >= PASSWORD_MIN_LENGTH
            && password.Length <= PASSWORD_MAX_LENGTH;
    }

    public bool IsAdministrator() {
        return this.Roles.Any(role => {
            return role.Id == Role.ADMIN_ROLE_ID;
        });
    }

    public bool IsOfficeEmployee() {
        return this.Roles.Any(role => {
            return role.Id == Role.OFFICE_EMPLOYEE_ROLE_ID;
        });
    }

    public bool IsWarehouseEmployee() {
        return this.Roles.Any(role => {
            return role.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID;
        });
    }
}
