using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Role {
    public const int ADMIN_ROLE_ID = 1;
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;
    public const int NAME_MAX_LENGTH = 64;
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
            if (!ValidateName(value)) {
                throw new ArgumentOutOfRangeException("Description", $"Description length must be lower than or equal to {DESCRIPTION_MAX_LENGTH} characters.");
            }
            this.description = value;
        }
    }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    public virtual List<User> Users { get; set; } = new List<User>();



    public Role(string name, string description) {
        this.Name = name;
        this.Description = description;
    }

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



    public static bool ValidateId(int id) {
        return id >= 0;
    }

    public static bool ValidateName(string name) {
        return name.Length <= NAME_MAX_LENGTH;
    }

    public static bool ValidateDescription(string description) {
        return description.Length <= DESCRIPTION_MAX_LENGTH;
    }

}
