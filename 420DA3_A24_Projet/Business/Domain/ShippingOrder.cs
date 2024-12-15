using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrder {
  
    public const int STATUS_MAX_LENGTH = 30;


    // Backing fields
    private int id;
    private System.Enum status;
    private int sourceClientId;
    private int creatorEmployeeId;
    private int destinationAddressId;
    private int? fulfillerEmployeeId;
    private DateTime? shippingDate;

    // Propriétés
    public int Id { get; set; }
    public ShippingOrderStatusEnum Status;
    public int? ShipmentId { get; set; }
    public int SourceClientId { get; set; }
    public int CreatorEmployeeId { get; set; } 
    public int DestinationAddressId { get; set; }
    public int? FulfillerEmployeeId { get; set; }
    public DateTime? ShippingDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    // Propriétés de navigation
    public Client SourceClient { get; set; } = null!;
    public Shipment? Shipment { get; set; }
    public User CreatorEmployee { get; set; } = null!;
    public User? FulfillerEmployee { get; set; }
    public Address DestinationAddress { get; set; } = null!;
    public List<ShippingOrderProduct> ShippingOrderProduct { get; set; } = new();

    // Constructeur
    public ShippingOrder(
        int sourceClientId,
        int creatorEmployeeId,
        int destinationAddressId) {
        SourceClientId = sourceClientId;
        CreatorEmployeeId = creatorEmployeeId;
        DestinationAddressId = destinationAddressId;
        Status = ShippingOrderStatusEnum.New;
        DateCreated = DateTime.Now;
    }

    // Méthodes
    public void AssignToWhEmployee(User employee) {
        if (Status != ShippingOrderStatusEnum.New)
            throw new InvalidOperationException("Cannot assign employee unless order is in Created status");

        FulfillerEmployee = employee;
        FulfillerEmployeeId = employee.Id;
        Status = ShippingOrderStatusEnum.Processing;
        DateModified = DateTime.Now;
    }

    public void MarkPackaged() {
        if (Status != ShippingOrderStatusEnum.Unassigned)
            throw new InvalidOperationException("Cannot mark as packaged unless order is Assigned");

        Status = ShippingOrderStatusEnum.Packaged;
        DateModified = DateTime.Now;
    }

    public void MarkShipped() {
        if (Status != ShippingOrderStatusEnum.Packaged)
            throw new InvalidOperationException("Cannot mark as shipped unless order is Packaged");

        Status = ShippingOrderStatusEnum.Shipped;
        ShippingDate = DateTime.Now;
        DateModified = DateTime.Now;
    }

    public override string ToString() {
        return $"ShippingOrder [ID={Id}, Status={Status}, SourceClientId={SourceClientId}, " +
               $"CreatorEmployeeId={CreatorEmployeeId}, DestinationAddressId={DestinationAddressId}, " +
               $"FulfillerEmployeeId={FulfillerEmployeeId}, ShippingDate={ShippingDate}]";
    }
}
