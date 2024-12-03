using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Client
{
    public const int CLIENTNAME_MAX_LENGTH = 128;
    public const int CONTACTFIRSTNAME_MAX_LENGTH = 32;
    public const int CONTACTLASTNAME_MAX_LENGTH = 32;
    public const int CONTACTEMAIL_MAX_LENGTH = 128;
    public const int CONTACTTELEPHONE_MAX_LENGTH = 15;

    // backing fields
    private int id;
    private string clientName = null!;

    // propriétés de données
    public int Id
    {
        get { return this.id; }
        set
        {
            if (!ValidateId(value))
            {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }
    public string ClientName
    {
        get { return this.clientName; }
        set
        {
            if (!ValidateClientName(value))
            {
                throw new ArgumentOutOfRangeException("ClientName", $"ClientName length must be lower than or equal to {CLIENTNAME_MAX_LENGTH} characters.");
            }
            this.clientName = value;
        }
    }

    public int WarehouseId { get; set; }
    public string ContactFirstName {  get; set; }
    public string ContactLastName { get; set; }
    public string ContactEmail { get; set; }
    public string ContactTelephone { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation
    public virtual List<Product> Products { get; set; } = new List<Product>();
    public virtual List<ShippingOrder> ShippingOrders { get; set; } = new List<ShippingOrder>();
    public virtual Warehouse AssignedWarehouse { get; set; }

    //Constructeurs
    public Client(int id,
        string clientName,
        int warehouseId,
        string contactFirstName,
        string contactLastName,
        string contactEmail,
        string contactTelephone,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
    {
        this.Id = id;
        this.ClientName = clientName;
        this.WarehouseId = warehouseId;
        this.ContactFirstName = contactFirstName;
        this.ContactLastName = contactLastName;
        this.ContactEmail = contactEmail;
        this.ContactTelephone = contactTelephone;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    public static bool ValidateId(int id)
    {
        return id >= 0;
    }

    public static bool ValidateClientName(string clientName)
    {
        return clientName.Length <= CLIENTNAME_MAX_LENGTH;
    }

    public static bool ValidateContactFirstName(string contactFirstName)
    {
        return contactFirstName.Length <= CONTACTFIRSTNAME_MAX_LENGTH;
    }

    public static bool ValidateContactLastName(string contactLastName)
    {
        return contactLastName.Length <= CONTACTLASTNAME_MAX_LENGTH;
    }

    public static bool ValidateContactEmail(string contactEmail)
    {
        return contactEmail.Length <= CONTACTEMAIL_MAX_LENGTH;
    }

    public static bool ValidateContactTelephone(string contactTelephone)
    {
        return contactTelephone.Length <= CONTACTTELEPHONE_MAX_LENGTH;
    }
}

