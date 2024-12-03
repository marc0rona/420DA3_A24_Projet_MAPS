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
    public int Client_Id { get { return client_id; } set { client_id = value; } }
    public int Address_Id { get { return address_id; } set { address_id = value; } }
    public int Employee_Warehouse_Id { get { return employee_warehouse_id; } set { employee_warehouse_id = value; } }
    public int Shipping_Id { get { return shipping_id; } set { shipping_id = value; } }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    // constructeur public

    public ShippingOrder(int id, string status, int client_id) {

        this.id = id;
        this.status = status;
        this.client_id = client_id;
        this.address_id = address_id;
        this.employee_warehouse_id = employee_warehouse_id;
        this.shipping_id = shipping_id;
    }

    // protected
    protected ShippingOrder(int id, string status, int client_id, int address_id, int employee_warehouse_id, int shipping_id) {
        this.id = id;
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
}
