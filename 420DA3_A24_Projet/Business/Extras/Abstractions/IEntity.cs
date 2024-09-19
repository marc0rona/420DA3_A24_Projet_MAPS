using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Extras.Abstractions;

/// <summary>
/// Interface pour les entités du domaine.
/// <br></br>
/// Elle force la définition de méthodes d'accès pour certaines propriétés 
/// considérées générales que toutes les entités du domaine devraient posséder:
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Id</item>
/// <item>DateCreated</item>
/// <item>DateModified</item>
/// <item>DateDeleted</item>
/// </list>
/// </remarks>
/// <typeparam name="TIdentifier">Le type de données de l'identifiant de l'entité du domaine.</typeparam>
public interface IEntity<TIdentifier>
{

    /// <summary>
    /// Getter pour l'identifiant dans la base de données de l'instance.
    /// </summary>
    /// <returns>L'identifiant de l'instance ou <see langword="null"/>.</returns>
    TIdentifier? GetId();

    /// <summary>
    /// Getter pour la date de création dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de création de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateCreated();

    /// <summary>
    /// Getter pour la date de dernière modification dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de dernière modification de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateModified();

    /// <summary>
    /// Getter pour la date de suppression dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de suppression de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateDeleted();

    /// <summary>
    /// Retourne <see langword="true"/> si l'instance est considérée comme supprimée dans la base de données.
    /// </summary>
    /// <remarks>
    /// Une instance est considérée supprimée lorsqu'elle possède une valeur non-<see langword="null"/> pour
    /// sa propriété de date de suppression.
    /// </remarks>
    /// <returns><see langword="true"/> si l'instance est considérée comme supprimée, <see langword="false"/> sinon.</returns>
    bool IsDeleted();

}
