using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class PurchaseOrder
{
    // Constantes
    public const int STATUS_MAX_LENGTH = 30;
    public const string STATUS_NEW = "new";
    public const string STATUS_COMPLETED = "completed";
    public const int PRODUCT_TO_RESTOCK_MAX_LENGTH = 50;
    public const int WAREHOUSE_MAX_LENGTH = 50;

    // Backing fields (private)
    private int id;
    private PurchaseOrderStatusEnum status;
    private int productId;
    private int warehouseId;
    private int quantity;
    private DateTime? completionDate;

    // Propriétés publiques
    public int Id { get { return id; } set { id = value; } }

    public PurchaseOrderStatusEnum Status {
        get { return status; }
        set { status = value; }
    }

    public int ProductId {
        get { return productId; }
        set { productId = value; }
    }

    public int WarehouseId {
        get { return warehouseId; }
        set { warehouseId = value; }
    }

    public int Quantity {
        get { return quantity; }
        set { quantity = value; }
    }

    public DateTime? CompletionDate {
        get { return completionDate; }
        set { completionDate = value; }
    }

    public DateTime DateCreated { get; private set; }
    public DateTime? DateModified { get; private set; }
    public DateTime? DateDeleted { get; private set; }
    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation
    public Product OrderedProduct { get; set; }
    public Warehouse Warehouse { get; set; }

    // Constructeur public
    public PurchaseOrder(
        int id,
        PurchaseOrderStatusEnum status,
        int productId,
        int warehouseId,
        int quantity) {
        this.id = id;
        this.status = status;
        this.productId = productId;
        this.warehouseId = warehouseId;
        this.quantity = quantity;
        this.DateCreated = DateTime.Now;
    }

    // Constructeur protégé pour l'ORM
    protected PurchaseOrder(
        int id,
        PurchaseOrderStatusEnum status,
        int productId,
        int warehouseId,
        int quantity,
        DateTime? completionDate,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(id, status, productId, warehouseId, quantity) {
        this.completionDate = completionDate;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    // Méthode pour compléter la commande
    public void Complete() {
        this.status = PurchaseOrderStatusEnum.Completed;
        this.completionDate = DateTime.Now;
        UpdateModificationDate();
    }

    // Mise à jour de la date de modification
    private void UpdateModificationDate() {
        this.DateModified = DateTime.Now;
    }

    // Représentation de l'objet
    public override string ToString() {
        return $"PurchaseOrder [ID={id}, Status={status}, ProductId={productId}, WarehouseId={warehouseId}, " +
               $"Quantity={quantity}, CompletionDate={completionDate}, DateCreated={DateCreated}, " +
               $"DateModified={DateModified}, DateDeleted={DateDeleted}]";
    }
}

