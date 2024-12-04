using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project_Utilities.Enums;



namespace _420DA3_A24_Projet.Business.Domain;

/* Auteur de la classe Address.cs : Pierre-Sylvestre Cypré */

public class Address {
    /// <summary>
    /// Longeur maximale de l'adresse, en caractères
    /// </summary>
    public const int ADDRESSEE_MAX_LENGTH = 64;
    /// <summary>
    /// Longeur maximale du numéro civique, en caractères
    /// </summary>
    public const int CIVIC_NUMBER_MAX_LENGTH = 6;
    /// <summary>
    /// Longeur maximale de la rue, en caractères
    /// </summary>
    public const int STREET_MAX_LENGTH = 128;
    /// <summary>
    /// Longeur maximale de la ville, en caractères
    /// </summary>
    public const int CITY_MAX_LENGTH = 64;
    /// <summary>
    /// Longeur maximale de la province, en caractères
    /// </summary>
    public const int STATE_MAX_LENGTH = 64;
    /// <summary>
    /// Longeur maximale du pays, en caractères
    /// </summary>
    public const int COUNTRY_MAX_LENGTH = 64;
    /// <summary>
    /// Longeur maximale du code postal, en caractères
    /// </summary>
    public const int POSTAL_CODE_MAX_LENGTH = 12;

    // Backing fields
    private int id;
    AddressTypesEnum addressType;
    private string addressee = null!;
    private string civicNumber = null!;
    private string street = null!;
    private string city = null!;
    private string state = null!;
    private string country = null!;
    private string postalCode = null!;

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

    public AddressTypesEnum AddressType { get; set; }

    public string Addressee {
        get { return this.addressee; }
        set {
            if (!ValidateRecipient(value)) {
                throw new ArgumentException($"Recipient must not be empty and must be {ADDRESSEE_MAX_LENGTH} characters or less.");
            }
            this.addressee = value;
        }
    }

    public string CivicNumber {
        get { return this.civicNumber; }
        set {
            if (!ValidateCivicNumber(value)) {
                throw new ArgumentException($"CivicNumber must not be empty and must be {CIVIC_NUMBER_MAX_LENGTH} characters or less.");
            }
            this.civicNumber = value;
        }
    }

    public string Street {
        get { return this.street; }
        set {
            if (!ValidateStreet(value)) {
                throw new ArgumentException($"Street must not be empty and must be {STREET_MAX_LENGTH} characters or less.");
            }
            this.street = value;
        }
    }

    public string City {
        get { return this.city; }
        set {
            if (!ValidateCity(value)) {
                throw new ArgumentException($"City must not be empty and must be {CITY_MAX_LENGTH} characters or less.");
            }
            this.city = value;
        }
    }

    public string State {
        get { return this.state; }
        set {
            if (!ValidateProvince(value)) {
                throw new ArgumentException($"Province must not be empty and must be {STATE_MAX_LENGTH} characters or less.");
            }
            this.state = value;
        }
    }

    public string Country {
        get { return this.country; }
        set {
            if (!ValidateCountry(value)) {
                throw new ArgumentException($"Country must not be empty and must be {CITY_MAX_LENGTH} characters or less.");
            }
            this.country = value;
        }
    }

    public string PostalCode {
        get { return this.postalCode; }
        set {
            if (!ValidatePostalCode(value)) {
                throw new ArgumentException($"PostalCode must not be empty and must be {CITY_MAX_LENGTH} characters or less.");
            }
            this.postalCode = value;
        }
    }

    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    #endregion

    #region Propriétés de navigation

    // Navigation properties to represent relationships
    /// <summary>
    /// The warehouse that owns this address (1-to-1 relationship).
    /// </summary>
    public virtual Warehouse? OwnerWarehouse { get; set; }

    /// <summary>
    /// The shipping order that uses this address (optional relationship).
    /// </summary>
    public virtual ShipmentOrders? OwnerShipOrder { get; set; }

    #endregion

    /// <summary>
    /// Constructeur public
    /// </summary>
    public Address(
        AddressTypesEnum addressType,
        string addressee,
        string civicNumber,
        string street,
        string city,
        string state,
        string country,
        string postalCode) {
        this.AddressType = addressType;
        this.Addressee = addressee;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.PostalCode = postalCode;
    }

    /// <summary>
    /// Constructeur protégé EF Core
    /// </summary>
    /// <param name="id"></param>
    /// <param name="addressee"></param>
    /// <param name="civicNumber"></param>
    /// <param name="street"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="country"></param>
    /// <param name="postalCode"></param>
    /// <param name="dateCreated"></param>
    /// <param name="dateModified"></param>
    /// <param name="dateDeleted"></param>
    /// <param name="rowVersion"></param>
    protected Address(
        int id,
        AddressTypesEnum addressType,
        string addressee,
        string civicNumber,
        string street,
        string city,
        string state,
        string country,
        string postalCode,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(addressType, addressee, civicNumber, street, city, state, country, postalCode) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #region Méthodes
    /// <summary>
    /// Méthode de valiation d'ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool ValidateId(int id)
    {
        return id >= 0;
    }

    /// <summary>
    /// Méthode de validation du numéro civique
    /// </summary>
    /// <param name="civicNumber"></param>
    /// <returns></returns>
    public static bool ValidateCivicNumber(string civicNumber)
    {
        return civicNumber.Length <= CIVIC_NUMBER_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation de la ville
    /// </summary>
    /// <param name="city"></param>
    /// <returns></returns>
    public static bool ValidateCity(string city)
    {
        return city.Length <= CITY_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation de la rue
    /// </summary>
    /// <param name="street"></param>
    /// <returns></returns>
    public static bool ValidateStreet(string street)
    {
        return street.Length <= STREET_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation du destinataire (receveur)
    /// </summary>
    /// <param name="addressee"></param>
    /// <returns></returns>
    public static bool ValidateRecipient(string addressee)
    {
        return addressee.Length <= ADDRESSEE_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation de la province (state)
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public static bool ValidateProvince(string state)
    {
        return state.Length <= STATE_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation du pays
    /// </summary>
    /// <param name="country"></param>
    /// <returns></returns>
    public static bool ValidateCountry(string country)
    {
        return country.Length <= COUNTRY_MAX_LENGTH;
    }
        
    /// <summary>
    /// Méthode de validation du code postal
    /// </summary>
    /// <param name="postalCode"></param>
    /// <returns></returns>
    public static bool ValidatePostalCode(string postalCode) 
    {
    return postalCode.Length <= POSTAL_CODE_MAX_LENGTH;
    }

    #endregion
}
