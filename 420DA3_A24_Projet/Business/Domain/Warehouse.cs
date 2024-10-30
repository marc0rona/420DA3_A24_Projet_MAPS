using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Warehouse
{
    public const int WAREHOUSENAME_MAX_LENGTH = 128;

    // backing fields
    private int id;
    private string warehouseName = null!;

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
    public string WarehouseName
    {
        get { return this.warehouseName; }
        set
        {
            if (!ValidateWarehouseName(value))
            {
                throw new ArgumentOutOfRangeException("WarehouseName", $"WarehouseName length must be lower than or equal to {WAREHOUSENAME_MAX_LENGTH} characters.");
            }
            this.warehouseName = value;
        }
    }

    public int AddressId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation
    public virtual List<Client> Clients { get; set; } = new List<Client>();
    //public virtual Address AssignedAddress { get; set; }
    //public virtual List<PurchaseOrder> RestockOrders { get; set; } = new List<PurchaseOrder>();
    public virtual List<User> WarehouseEmployees { get; set; } = new List<User>();

    //Constructeurs 
    public Warehouse(int id,
        string warehouseName,
        int addressId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
    {
        this.Id = id;
        this.WarehouseName = warehouseName;
        this.AddressId = addressId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    public static bool ValidateId(int id)
    {
        return id >= 0;
    }

    public static bool ValidateWarehouseName(string warehouseName)
    {
        return warehouseName.Length <= WAREHOUSENAME_MAX_LENGTH;
    }
}


