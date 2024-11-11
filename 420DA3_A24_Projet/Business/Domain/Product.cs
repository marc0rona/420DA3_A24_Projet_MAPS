using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    private string ProdDesc_Verif;
    private string IMG_FileName_Verif;
    private string SuppCode_Verif = null!; //Non-nullable, nécessaire

    #region 1 - Propriétés de données (FIELD - CHAMPS)
    public int Id {
        get; //{ return this.id_Verif; } //prend variable privé
        set;
    }

    #endregion 1 - Propriétés de données
}
