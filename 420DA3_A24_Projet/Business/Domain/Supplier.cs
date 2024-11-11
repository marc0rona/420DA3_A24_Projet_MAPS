using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Supplier
{
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
    public int Id {
        get; //{ return this.id_Verif; } //prend variable privé
        set;
    }

    #endregion Propriétés de données
}
