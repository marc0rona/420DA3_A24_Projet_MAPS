using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Shipments
{
    // constantes
    public const string PUROLATOR = "Purolator";
    public const string POSTES_CANADA = "PostesCanada";
    public const string FEDEX = "FedEx";

    // backing fields
    private int id;
    private string deliveryService = null!;
    private string trackingCode = null!;
    private string destinationAddress = null!; // Ajouter Address en tant que datatype au lieu de string... apres la création de adresse


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
    public string DeliveryService
    {
        get { return this.deliveryService; }
        set
        {
            if(!IsValidDeliveryService(value))
            {
                throw new ArgumentException("Invalid delivery service. Must be Purolator, PostesCanada, or FedEx.");
            }
            this.deliveryService = value;
        }
    }
    public string TrackingCode
    {
        get { return this.trackingCode; }
        set { this.trackingCode = value; }
    }

    public string? DestinationAddress { get; set; } // Address datatype
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation
    // to-do...



    public Shipments (string deliveryService, string trackingCode, string destinationAddress) // Address datatype
    {
        this.DeliveryService = deliveryService;
        this.TrackingCode = trackingCode;
        this.DestinationAddress = destinationAddress;
    } 

    protected Shipments (int id,
        string deliveryService, 
        string trackingCode, 
        string? destinationAddress, 
        DateTime dateCreated, 
        DateTime? dateModified, 
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(deliveryService, trackingCode, destinationAddress)
    {
        this.Id = id;
        this.DeliveryService = deliveryService;
        this.TrackingCode = trackingCode;
        this.DestinationAddress = destinationAddress;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.RowVersion = rowVersion;
    }
        


    public static bool ValidateId(int id)
    {
        return id >= 0; 
    }


    public static bool IsValidDeliveryService(string service)
    {
        return service == PUROLATOR || service == POSTES_CANADA || service == FEDEX;
    }
}
