using _420DA3_A24_Projet.Business.Services;
using Microsoft.Identity.Client;
using Project_Utilities.Enums;
using Project_Utilities.Services.APIs;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant les expéditions générées par les employés d'entrepôt
/// </summary>

public class Shipment {
    /// <summary>
    /// Longeur maximale du code de suivi
    /// </summary>
    public const int TRACKING_NUMBER_MAX_LENGTH = 32;

    // Backing fields
    private int id;
    private ShipmentStatusEnum status;
    private ShippingProvidersEnum shippingService;
    private int shippingOrderId;
    private string trackingNumber = null!;

    #region Propriétés de données
    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }

    public ShipmentStatusEnum Status { get; set; }

    public ShippingProvidersEnum ShippingService { get; set; }

    public int ShippingOrderId {
        get { return this.shippingOrderId; }
        set {
            if (value <= 0) {
                throw new ArgumentOutOfRangeException("ShippingOrderId", "Id must be greater than or equal to 0.");
            }
            this.shippingOrderId = value;
        }
    }

    public string TrackingNumber {
        get { return this.trackingNumber; }
        private set {
            if (!ValidateTrackingNumber(value)) {
                throw new ArgumentException($"TrackingNumber must not exceed {TRACKING_NUMBER_MAX_LENGTH} characters.");
            }
            this.trackingNumber = value;
        }
    }

    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    #endregion


    #region Propriétés de navigation
    /// <summary>
    /// La l'expédition de commande de l'expédition
    /// </summary>
    public virtual ShippingOrder ShippingOrder { get; set; }

    #endregion

    /// <summary>
    /// Constructeur public pour Shipment
    /// </summary>
    /// <param name="shippingOrderId">Id de la commande de l'expédition</param>
    /// <param name="trackingNumber">Numéro de suivi de l'expédition</param>
    public Shipment(
        ShipmentStatusEnum status, 
        ShippingProvidersEnum shippingService, 
        int shippingOrderId, 
        string trackingNumber) {
        this.status = status;
        this.shippingService = shippingService;
        this.shippingOrderId = shippingOrderId;
        this.trackingNumber = trackingNumber;
    }

    /// <summary>
    /// Constructeur orienté EF CORE
    /// </summary>
    /// <param name="id">L'identifiant de l'expédition</param>
    /// <param name="shippingOrderId">Id de la commande</param>
    /// <param name="trackingNumber">Numéro de suivi</param>
    /// <param name="dateCreated">La date de création de l'expédition dans la base de données</param>
    /// <param name="dateModified">La date de modification de l'expédition dans la base de données</param>
    /// <param name="dateDeleted">La date de suppression de l'expédition dans la base de données</param>
    /// <param name="rowVersion">Le numéro de version anti-concurrence de l'entrée dans la base de donnéees.</param>
    protected Shipment(int id,
        ShipmentStatusEnum status,
        ShippingProvidersEnum shippingService,
        int shippingOrderId,
        string trackingNumber,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(status, shippingService, shippingOrderId, trackingNumber) 
    {
        this.Id = id;
        this.status = status;
        this.shippingService = shippingService;
        this.ShippingOrderId = shippingOrderId;
        this.TrackingNumber = trackingNumber;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #region Méthodes
    /// <summary>
    /// Méthode de validaton d'ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool ValidateId(int id) {

        return id >= 0;
    }
    /// <summary>
    /// Méthode de validation du code de suivi
    /// </summary>
    /// <param name="trackingNumber"></param>
    /// <returns></returns>
    public static bool ValidateTrackingNumber(string trackingNumber) {
        return trackingNumber.Length <= TRACKING_NUMBER_MAX_LENGTH;
    }
    #endregion
}
