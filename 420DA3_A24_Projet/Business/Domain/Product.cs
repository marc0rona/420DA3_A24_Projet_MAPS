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
    private string IMG_FileName_Verif = null;
    private string SuppCode_Verif = null;
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
    //1 : Validation Name
    public string ProductName {
        get { return this.ProdName_Verif; }
        set {
              if (!ValidateProductName(value)) { throw new ArgumentOutOfRangeException("Name", $"Name inputed is too long. Maximum number of characters allowed is {PROD_NAME_MAXLENGHT} chars.\nPlease respect the limit norms, thank you."); }
              this.ProdName_Verif = value;
            }
    }
    //2 : Validation Description
    public string ProductDesc {
        get { return this.ProdDesc_Verif; }
        set {
              if (!ValidateProductDescription(value)) { throw new ArgumentOutOfRangeException("Description", $"Description length must be lower than or equal to {PROD_DESCRIPTION_MAXLENGHT} characters.\nPlease respect the limit norms, thank you."); }
              this.ProdDesc_Verif = value;
            }
    }
    //3 : Validation code UPC du Produit
    public string Product_CodeUPC {
        get { return this.ProdCode_Verif; }
        set { if (!ValidateUpCode(value)) { throw new ArgumentOutOfRangeException("Code UPC", $"The Code is too long. Maximum number of characters allowed is {UP_CODE_MAXLENGHT} chars.\nPlease respect the limit norms, thank you."); }
              this.ProdCode_Verif = value;
            }
    } 
    //4 : Validation code du Fournisseur
    public string? Supplier_Code {
        get { return this.SuppCode_Verif; }
        set { if (!ValidateSupplier(value)) { throw new ArgumentOutOfRangeException("Supplier", $"Code length must be lower than or equal to {SUPPLIER_CODE_MAXLENGHT} characters.\nPlease respect the limit norms, thank you."); }
              this.SuppCode_Verif = value;
            }
    }
    //5 : Validation Nom de l'image (se rappeler que se peut etre NULL, > ToDo)
    public string? Image_FileName {
        get { return this.IMG_FileName_Verif; }
        set { if (!ValidateImageFileName(value)) { throw new ArgumentOutOfRangeException("File Name", $"File Name is too long. Maximum number of characters allowed is {IMG_FILE_NAME_MAXLENGHT} chars.\nPlease respect the limit norms, thank you."); }
              this.IMG_FileName_Verif = value;
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
    //9 + 10 : Client du Produit - Infos
    public int ProdOwnerClient_Id { get; set; }
    public Client ProdOwnerClient { get; set; }
    //11 + 12 : Fournisseur du Produit - Infos
    public int ProdSupplier_Id { get; set; }
    public Supplier ProdSupplier { get; set; } = null!; //doit avoir toujours un fournisseur

    //13 - 15 : Variables Dates
    public DateTime DateCreated { get; set; }
    //Variables Nullables
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    //16 + 17 : LISTES pour gérer les expéditions reliés au produit & client
    public List<PurchaseOrders> OrderPurchases { get; set; } = new List<PurchaseOrders>(); //CHANGE THE INTERNAL TO PUBLIC CLASS, ABOUBACAR PLEASE. THANK YOU
    public List<ShipmentOrders> OrderShipments { get; set; } = new List<ShipmentOrders>();
    //ToDo : Gerer si les expeditions sont vide (aucunes valeurs dans colonne);]
    public byte[] RowVersion { get; set; } = null!; //Non-nullable, nécessaire
    #endregion 1 - Propriétés de données

    #region 2 - Propriétés de navigation
    //ToDo Later 
    #endregion Propriétés de navigation
    /// Constructors

    //1er Const : Orienté Création Manuelle/UI par employé de bureau
    public Product(int ID, string nom, string description, string codeUPC, string? IMG_nom, int client_ID, int supplier_ID, string? supplier_code)  //(7 Arguments, valeurs qui sont assignés manuellements)
    {
        this.Id = ID;
        this.ProductName = nom;
        this.ProductDesc = description;
        this.Product_CodeUPC = codeUPC;
        this.Image_FileName = IMG_nom;

        this.ProdOwnerClient_Id = client_ID;
        this.ProdSupplier_Id = supplier_ID;
        this.Supplier_Code = supplier_code;
    }
    //2me Const : avec 3 arguments de plus (5 + 3 Arguments pour Qntés & poids)
    public Product(int ID, string nom, string description, string codeUPC, string? IMG_nom, int client_ID, int supplier_ID, string? supplier_code,
                   Int32 Qty_1, Int32 Qty_2, Double weight) : this(ID, nom, description, codeUPC, IMG_nom, client_ID, supplier_ID, supplier_code) //Reprend valeurs du 1er Const
    {
        this.Qty_InStock = Qty_1;
        this.Qty_Desired = Qty_2;
        this.Weight_inKg = weight;
    }

    // 3me Const Orienté Entity-Framework + Valeurs automaticaques created by DataBase SQL (comme les DateTimes)
    protected Product(int ID, // 0
                      string nom,
                      string description, // 2
                      string codeUPC,
                      string? IMG_nom, // 4
                      int client_ID,
                      int supplier_ID,// 6
                      string? supplier_code,
                      Int32 Qty_1, // 8
                      Int32 Qty_2,
                      Double weight, // 10      
                        DateTime dateCreated,
                        DateTime? dateModified,
                        DateTime? dateDeleted,
                        byte[] rowVersion)
                        : this(ID, nom, description, codeUPC, IMG_nom, client_ID, supplier_ID, supplier_code, Qty_1, Qty_2, weight) //Reprend valeurs du 1er + 2me Consts
    {
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }
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
    public static bool IsDueForRestocking(int quantity_inStock) 
        { return (quantity_inStock == 0); } //seulement retourne TRUE si la condition est appliqué (sinon FALSE) 
    #endregion
}

