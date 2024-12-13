using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class PurchaseOrder
{
    // Constantes
    public const int STATUS_MAX_LENGTH = 30;
    public const string STATUS_NEW = "new";
    public const string STATUS_COMPLETED = "completed";
    public const int PRODUCT_TO_RESTOCK_MAX_LENGTH = 50;
    public const int WAREHOUSE_MAX_LENGTH = 50;

    // Backing fields (private)
    private int id;
    private string status;
    private string productToRestock;
    private string warehouse;
    private int quantityToOrder;
    private DateTime? completionDate;

    // Propriétés publiques
    public int Id { get { return id; } set { id = value; } }
    public string Status {
        get { return status; }
        set {
            if (!ValidateStatus(value)) {
                throw new ArgumentException($"Status must be either '{STATUS_NEW}' or '{STATUS_COMPLETED}', and cannot exceed {STATUS_MAX_LENGTH} characters.");
            }
            status = value;
        }
    }
    public string ProductToRestock {
        get { return productToRestock; }
        set {
            if (!ValidateProductToRestock(value)) {
                throw new ArgumentException($"Product to restock cannot exceed {PRODUCT_TO_RESTOCK_MAX_LENGTH} characters.");
            }
            productToRestock = value;
        }
    }
    public string Warehouse {
        get { return warehouse; }
        set {
            if (!ValidateWarehouse(value)) {
                throw new ArgumentException($"war cannot exceed {WAREHOUSE_MAX_LENGTH} characters.");
            }
            warehouse = value;
        }
    }
    
    public int QuantityToOrder { get { return quantityToOrder; } set { quantityToOrder = value; } }
    public DateTime? CompletionDate { get { return completionDate; } set { completionDate = value; } }
    public DateTime DateCreated { get; private set; }
    public DateTime? DateModified { get; private set; }
    public DateTime? DateDeleted { get; private set; }
    public byte[] RowVersion { get; set; } = null!;

    // Constructeur public
    public PurchaseOrder(int id, string status, string productToRestock, string warehouse, int quantityToOrder) {
        this.id = id;
        this.Status = status;
        this.ProductToRestock = productToRestock;
        this.Warehouse = warehouse;
        this.QuantityToOrder = quantityToOrder;
        
    }

   
    // Validation du statut
    public static bool ValidateStatus(string status) {
        return (status == STATUS_NEW || status == STATUS_COMPLETED) && status.Length <= STATUS_MAX_LENGTH;
    }
    public static bool ValidateProductToRestock(string productToRestock) {
        return productToRestock.Length <= PRODUCT_TO_RESTOCK_MAX_LENGTH;  
    }
    public static bool ValidateWarehouse(string warehouse) {
        return warehouse.Length <= WAREHOUSE_MAX_LENGTH;
    }

    // Mise à jour de la date de modification
    private void UpdateModificationDate() {
        this.DateModified = DateTime.Now;
    }

    // Représentation de l'objet
    public override string ToString() {
        return $"PurchaseOrder [ID={id}, Status={status}, ProductToRestock={productToRestock}, Warehouse={warehouse}, " +
               $"QuantityToOrder={quantityToOrder}, CompletionDate={completionDate}, DateCreated={this.DateCreated}, " +
               $"DateModified={this.DateModified}, DateDeleted={this.DateDeleted}]";
    }
}

