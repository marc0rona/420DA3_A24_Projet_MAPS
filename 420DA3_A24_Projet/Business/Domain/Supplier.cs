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
    public const int CONTACT_PHONE_MAXLENGHT = 15;
    public const int CONTACT_EMAIL_MAXLENGHT = 128;

    ///Champs (Field) : privés qui servent pour vérifier/valider les Limites
    private int id_Verif; //si id devient 'negatif'
    private string SuppName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_FirstName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_LastName_Verif = null!; //Non-nullable, nécessaire
    private string Cont_Phone_Verif;
    private string Cont_Email_Verif;

    #region Propriétés de données (FIELD - CHAMPS)
    //0 : Validation ID 
    public int Id {
        get { return this.id_Verif; } //prend variable privé
        set {   //En utilisant notre Methode, check si pas Positif (! + ValidateP).
            if (!ValidateId(value)) { throw new ArgumentOutOfRangeException("Id", "Id is negative. Id must be greater than or equal to 0."); }
            this.id_Verif = value; //< Sinon = valide le input 
        }
    }
    //1 : Validation SupplierName
    public string SupplierName {
        get;
        set;
    }
    //2 + 3 : Validation Noms du Contacte
    public string Contact_FirstName {
        get;
        set;
    }
    public string Contact_LastName {
        get;
        set;
    }
    //4 : Contact Courriel Elec
    public string Contact_Email {
        get;
        set;
    }
    //5 : Contact Téléphone
    public string Contact_Phone {
        get;
        set;
    }
    //6 - 8 : Variables Dates
    public DateTime DateCreated { get; set; }
    //Variables Nullables
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    //9 : LISTE pour gérer multiples produits qui peuventêtre liés a un Fournisseur
    public List<Product> Products_List { get; set; }
    #endregion Propriétés de données

    #region Propriétés de navigation
    //ToDo Later 

    #endregion Propriétés de navigation
    ///Constructors

    // Const orienté Création Manuelle/UI par employé de bureau
    public Supplier(int ID, string nomFournisseur, string prenom, string nom, string phone, string courriel) {


    }
    // ToDo : 2me Const (valeurs automaticaques created by DataBase SQL)

    // ToDo : Const Orienté Entity-Framework

    #region MÉTHODES
    public static bool ValidateId(int Supplier_id) 
        { return Supplier_id >= 0; } //doit etre positif 
    public static bool ValidateSupplierName(string nom) 
        { return nom.Length <= SUPPLIER_NAME_MAXLENGHT; } //est elle <= que le maximum?
    public static bool ValidateContact_FirstName(string nom) 
        { return nom.Length <= CONTACT_NAME_MAXLENGHT; }
    public static bool ValidateContact_LastName(string Prenom) 
        { return Prenom.Length <= CONTACT_NAME_MAXLENGHT; }
    public static bool ValidateContactPhone(string telefone) 
        { return telefone.Length <= CONTACT_PHONE_MAXLENGHT; }
    public static bool ValidateContactEmail(string email) 
        { return email.Length <= CONTACT_EMAIL_MAXLENGHT; }
}
    #endregion
