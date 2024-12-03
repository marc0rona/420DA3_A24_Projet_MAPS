using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrder {
  
    public const int STATUS_MAX_LENGTH = 30;


    // backing fields (private)
    private int id;
    private string status;
    private int client_id;
    private int creator_id;
    private int address_id;
    private int employee_warehouse_id;
    private int shipping_id;
    


    // propiétés (public)
    public int Id { get { return id; } set { id = value; } }
    public string Status {
        get { return status; }
        set {
            if (!ValidateStatus (value)) {

                throw new ArgumentException($"Status cannot exceed {STATUS_MAX_LENGTH} characters.");
            }
           this.status = value;

        }
    }
    public int Client_Id { get; set; }
    public int Creator_Id { get; set; }
    public int Address_Id { get; set; }
    public int Employee_Warehouse_Id { get; set; }
    public int Shipping_Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public object Creator { get; internal set; }


    // constructeur public

    public ShippingOrder(int id, 
        string status, 
        int client_id, 
        int creator_id, 
        int address_id, 
        int employee_warehouse_id, 
        int shipping_id) {

        this.Id = id;
        this.Status = status;
        this.Client_Id = client_id;
        this.Creator_Id = creator_id;
        this.Address_Id = address_id;
        this.Employee_Warehouse_Id = employee_warehouse_id;
        this.Shipping_Id = shipping_id;

    }

    // protected
    protected ShippingOrder(
        int id,
        string status,
        int client_id,
        int creator_id,
        int address_id,
        int employee_warehouse_id,
        int shipping_id,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(status, client_id, address_id, employee_warehouse_id, shipping_id) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public ShippingOrder(string status, int client_id, int creator_id, int address_id, int employee_warehouse_id, int shipping_id) {
        this.status = status;
        this.client_id = client_id;
        this.Creator_Id = creator_id;
        this.address_id = address_id;
        this.employee_warehouse_id = employee_warehouse_id;
        this.shipping_id = shipping_id;
    }

    public ShippingOrder(string status, int client_id, int address_id, int employee_warehouse_id, int shipping_id) {
        this.status = status;
        this.client_id = client_id;
        this.address_id = address_id;
        this.employee_warehouse_id = employee_warehouse_id;
        this.shipping_id = shipping_id;
    }

    // fonctions et méthodes
    public void UpdateStatus(string newStatus) {
        if (newStatus.Length <= STATUS_MAX_LENGTH) {
            status = newStatus;
        } else {
            throw new ArgumentException($"Status cannot exceed {STATUS_MAX_LENGTH} characters.");
        }
    }
    public static bool ValidateStatus( string status) {  return status.Length <= STATUS_MAX_LENGTH; }

    public override string ToString() {
        return $"ShipmentOrder [ID={id}, Status={status}, ClientID={client_id}, AddressID={address_id}, EmployeeWarehouseID={employee_warehouse_id}, ShippingID={shipping_id}]";
    }

    internal static object Creator_id() {
        throw new NotImplementedException();
    }
}
