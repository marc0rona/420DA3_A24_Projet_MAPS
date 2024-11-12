using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _420DA3_A24_Projet.Business.Domain; //adding the domain for linking with other classes


public class Product
{
    ///Limites pour les variables strings
    public const int UP_CODE_MAXLENGHT = 24;
    public const int PROD_NAME_MAXLENGHT = 255;
    public const int PROD_DESCRIPTION_MAXLENGHT = 1024;
    public const int IMG_FILE_NAME_MAXLENGHT = 128;
    public const int SUPPLIER_CODE_MAXLENGHT = 24; //Fournisseur associé au Produit

    ///Champs (Field) : privés qui servent pour vérifier/valider les Limites
    private int id_Verif; //si id devient 'negatif' 
    private string ProdName_Verif = null!; //Non-nullable, nécessaire
    private string ProdDesc_Verif = null!;
    private string ProdCode_Verif = null!;
    private string IMG_FileName_Verif;
    private string SuppCode_Verif = null!;
    //Variables pour les quantités + poids (ne peuvent pas être négatives)
    private Int32 Qty_instock_Verif; //Non-nullable, nécessaire
    private Int32 Qty_desired_Verif;
    private Double weight_Verif;

    #region 1 - Propriétés de données (FIELD - CHAMPS)
    //0 : Validation ID 
    public int Id 
    {
        get { return this.id_Verif; } //prend variable privé
        set {   //En utilisant notre Methode, check si pas Positif (! + ValidateP). Si oui, throw ArgOutOfRangeEx( ParamName, Message )
            if (!ValidatePositiveNumber(value)) { throw new ArgumentOutOfRangeException("Id", "Id is negative. Id must be greater than or equal to 0."); }
            this.id_Verif = value; //< Sinon = valide le input 
        }
    }
    //6 + 7 : Validation Quantités de Produits (en KG)
    public int Qty_InStock {
        get { return this.Qty_instock_Verif; }
        set {
            if (!ValidatePositiveNumber(value)) { throw new ArgumentOutOfRangeException("Quantity", "Quantity is negative. A Quantity value must be greater than or equal to 0."); }
            this.Qty_desired_Verif = value; //< Sinon = valide le input 
        }
    }
    public int Qty_Desired {
        get { return this.Qty_desired_Verif; }
        set {
            if (!ValidatePositiveNumber(value)) { throw new ArgumentOutOfRangeException("Quantity", "Quantity is negative. A Quantity value must be greater than or equal to 0."); }
            this.Qty_desired_Verif = value; //< Sinon = valide le input 
        }
    }
    //8 : Validation du poids en KG
    public double Weight_inKg {
        get { return this.weight_Verif; }
        set {
            if (!ValidatePositiveNumber(value)) { throw new ArgumentOutOfRangeException("Weight", "The weight is negative. Weight value in kilograms must be greater than or equal to 0."); }
            this.weight_Verif = value; //< Sinon = valide le input 
        }
    }
    #endregion 1 - Propriétés de données

    #region 2 - Propriétés de navigation
    //ToDo Later 
    #endregion Propriétés de navigation
    /// Constructors

    // Const Orienté Création Manuelle/UI par employé de bureau
    public Product(int ID, string code, string nom, string description, string? IMG_nom, string supplier, Int32 Qty_1, Int32 Qty_2)  //(5 + 2 (Qntés) Arguments, valeurs qui sont assignés manuellements)
    {
        // ToDo

    }

    // ToDo : 2me Const (valeurs automaticaques created by DataBase SQL)

    // ToDo : Const Orienté Entity-Framework
    #region 3 - MÉTHODES
    public static bool ValidatePositiveNumber(double numb) 
        { return numb >= 0; } //doit etre positif 
    public static bool ValidateUpCode(string code) 
        { return code.Length <= UP_CODE_MAXLENGHT; } //est elle plus petit que le maximum?
    public static bool ValidateProductName(string Prod_nom) 
        { return Prod_nom.Length <= PROD_NAME_MAXLENGHT; }
    public static bool ValidateProductDescription(string Prod_desc) 
        { return Prod_desc.Length <= PROD_DESCRIPTION_MAXLENGHT; }
    public static bool ValidateImageFileName(string IMG) 
        { return IMG.Length <= IMG_FILE_NAME_MAXLENGHT; }
    public static bool ValidateSupplier(string code) 
        { return code.Length <= SUPPLIER_CODE_MAXLENGHT; }

    //ToDo : public static bool IsDueForRestocking() {  } 
    #endregion
}

