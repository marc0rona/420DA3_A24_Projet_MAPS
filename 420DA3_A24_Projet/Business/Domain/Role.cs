using ExtraAdvancedMultiTier.Business.Abstractions;

namespace _420DA3_A24_Projet.Business.Domain;
public class Role : AbstractEntity<int> {

    // L'utilisation des structures avancées fournies (ici l'héritage de AbstractEntity<int>)
    // ajoute automatiquement une propriété Id de type int,
    // des propriétés DateCreated, DateModified et DateDeleted de type DateTime,
    // et une propriété RowVersion de type byte[].
    // Je n'ai donc pas besoin de les ajouter ici vu qu'elles sont héritées

    // propriétés de données
    public string RoleName { get; set; }
    public string RoleDescription { get; set; }

    // propriétés de navigation
    public List<User> RoleUsers { get; set; } = new List<User>();

    public Role(string roleName, string roleDescription) {
        this.RoleName = roleName;
        this.RoleDescription = roleDescription;
    }

    public Role(int id, string roleName, string roleDescription, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion) { }
}
