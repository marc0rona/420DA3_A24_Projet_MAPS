using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _420DA3_A24_Projet.Business.Domain; //adding the domain for linking with other classes

public class Supplier {
    //Limites pour les variables strings
    public const int SUPPLIER_NAME_MAXLENGHT = 128;
    public const int CONTACT_NAME_MAXLENGHT = 32;
    public const int CONTACT_EMAIL_MAXLENGHT = 100;
    public const int CONTACT_PHONE_MAXLENGHT = 15;

    ///Champs (Field) : privés qui servent pour vérifier/valider les Limites
    private int id_Verif; //si id devient 'negatif'
    private string SuppName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_FirstName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_LastName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_Email_Verif = null;
    private string Cont_Phone_Verif = null;

    #region Propriétés de données (FIELD - CHAMPS)
    //0 : Validation ID 
    public int Id {
        get { return this.id_Verif; } //prend variable privé
        set { //En utilisant notre Methode, check si pas Positif (! + ValidateP).
              if (!ValidateId(value)) { throw new ArgumentOutOfRangeException("Id", "Id is negative. Id must be greater than or equal to 0."); }
              //< Sinon = valide le input 
              this.id_Verif = value; 
            }
    }
    //1 : Validation SupplierName
    public string SupplierName {
        get { return this.SuppName_Verif; }
        set { if (!ValidateSupplierName(value)) { throw new ArgumentOutOfRangeException("Id", $"Supplier Company Name is too long. Maximum number of characters allowed is {SUPPLIER_NAME_MAXLENGHT} chars."); }
              this.SuppName_Verif = value;
            }
    }
    //2 + 3 : Validation Noms du Contacte
    public string Contact_FirstName {
        get { return this.Cont_FirstName_Verif; }
        set {
              if (!ValidateContactName(value)) { throw new ArgumentOutOfRangeException("Id", $"First Name inputed is too long. Maximum number of characters allowed is {CONTACT_NAME_MAXLENGHT} chars.\nPlease respect the limit norms, thank you."); }
              this.Cont_FirstName_Verif = value;
            }
    }
    public string Contact_LastName {
        get { return this.Cont_LastName_Verif; }
        set {
              if (!ValidateContactName(value)) { throw new ArgumentOutOfRangeException("Id", $"Last Name inputed is too long. Maximum number of characters allowed is {CONTACT_NAME_MAXLENGHT} chars.\nPlease respect the limit, thank you."); }
              this.Cont_LastName_Verif = value;
            }
    }
    //4 : Contact Courriel Elec
    public string? Contact_Email {
        get { return this.Cont_Email_Verif; }
        set { if (!ValidateContactEmail(value)) { throw new ArgumentOutOfRangeException("Id", $"Email is too long. Make it less than {CONTACT_EMAIL_MAXLENGHT} characters, please."); }
              this.Cont_Email_Verif = value;
            }
    }
    //5 : Contact Téléphone
    public string? Contact_Phone {
        get { return this.Cont_Phone_Verif; }
        set { if (!ValidateContactPhone(value)) { throw new ArgumentOutOfRangeException("Id", $"Phone Lenght is too long. Make it less than {CONTACT_PHONE_MAXLENGHT - 3} numbers, please."); }
              this.Cont_Phone_Verif = value;
            }
    }
    //6 - 8 : Variables Dates
    public DateTime DateCreated { get; set; }
    //Variables Nullables
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    //9 : LISTE pour gérer multiples produits qui peuventêtre liés a un Fournisseur
    public List<Product> Products_List { get; set; } = new List<Product>();
    public byte[] RowVersion { get; set; } = null!; //Non-nullable, nécessaire

    #endregion Propriétés de données

    #region Propriétés de navigation
    //ToDo Later 

    #endregion Propriétés de navigation
    ///Constructors

    // Const orienté Création Manuelle/UI par employé de bureau
    public Supplier(int ID, string nomFournisseur, string prenom, string nom, string? courriel, string? phone) 
    {
        this.Id = ID;
        this.SupplierName = nomFournisseur;
        this.Contact_FirstName = prenom;
        this.Contact_LastName = nom;
        this.Contact_Email = courriel;
        this.Contact_Phone = phone;
    }
    // 2me Const : Const Orienté Entity-Framework (valeurs automaticaques created by DataBase SQL)
    public Supplier(int ID, 
                    string nomFournisseur, 
                    string prenom, 
                    string nom, 
                    string? courriel, 
                    string? phone, 
                    DateTime dateCreated, 
                    DateTime? dateModified, 
                    DateTime? dateDeleted, 
                    byte[] rowVersion) 
                    : this(ID, nomFournisseur, prenom, nom, courriel, phone)
    {
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }
    #region MÉTHODES
    public static bool ValidateId(int Supplier_id) 
        { return Supplier_id >= 0; } //doit etre positif 
    public static bool ValidateSupplierName(string nom) 
        { return nom.Length <= SUPPLIER_NAME_MAXLENGHT; } //est elle <= que le maximum?
    public static bool ValidateContactName(string nom) 
        { return nom.Length <= CONTACT_NAME_MAXLENGHT; }
    public static bool ValidateContactEmail(string email) 
        { return email.Length <= CONTACT_EMAIL_MAXLENGHT; }
    public static bool ValidateContactPhone(string telefone) 
        { return telefone.Length <= CONTACT_PHONE_MAXLENGHT; }
}
    #endregion
