namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IDao<EntityType, EntityIdType>
    where EntityType : class, IEntity<EntityIdType>
    where EntityIdType : struct, IEquatable<EntityIdType> {


    /// <summary>
    /// Déclaration de méthode généralisée de requête globale pour <typeparamref name="EntityType"/>.
    /// </summary>
    /// <returns>La <see cref="List{T}">liste</see> des instances de <typeparamref name="EntityType"/> existantes</returns>
    public List<EntityType> GetAll();

    /// <summary>
    /// Déclaration de méthode généralisée de requête par identifiant pour <typeparamref name="EntityType"/>.
    /// </summary>
    /// <param name="id">L'identifiant de l'instance à obtenir</param>
    /// <returns>L'instance de <typeparamref name="EntityType"/> obtenue ou <see langword="null"/> si aucune ne correspond</returns>
    public EntityType? GetById(EntityType id);

    /// <summary>
    /// Déclaration de méthode généralisée d'insertion pour <typeparamref name="EntityType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="EntityType"/> à insérer</param>
    /// <returns>L'instance de <typeparamref name="EntityType"/> insérée</returns>
    public EntityType Create(EntityType instance);

    /// <summary>
    /// Déclaration de méthode généralisée de mise à jour pour <typeparamref name="EntityType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="EntityType"/> à mettre à jour</param>
    /// <returns>L'instance de <typeparamref name="EntityType"/> mise à jour</returns>
    public EntityType Update(EntityType instance);

    /// <summary>
    /// Déclaration de méthode généralisée de suppression pour <typeparamref name="EntityType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="EntityType"/> à supprimer</param>
    /// <returns>L'instance de <typeparamref name="EntityType"/> supprimée</returns>
    public EntityType Delete(EntityType instance);

}
