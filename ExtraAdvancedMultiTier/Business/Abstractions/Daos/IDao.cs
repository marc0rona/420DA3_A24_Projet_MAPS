namespace ExtraAdvancedMultiTier.Business.Abstractions.Daos;

public interface IDao {

}

public interface IDao<TEntity, TEntityKey> : IDao
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : struct, IEquatable<TEntityKey> {


    /// <summary>
    /// Déclaration de méthode généralisée de requête globale pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <returns>La <see cref="List{T}">liste</see> des instances de <typeparamref name="TEntity"/> existantes</returns>
    public List<TEntity> GetAll();

    /// <summary>
    /// Déclaration de méthode généralisée de requête par identifiant pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="id">L'identifiant de l'instance à obtenir</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> obtenue ou <see langword="null"/> si aucune ne correspond</returns>
    public TEntity? GetById(TEntityKey id);

    /// <summary>
    /// Déclaration de méthode généralisée d'insertion pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à insérer</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> insérée</returns>
    public TEntity Create(TEntity instance);

    /// <summary>
    /// Déclaration de méthode généralisée de mise à jour pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à mettre à jour</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> mise à jour</returns>
    public TEntity Update(TEntity instance);

    /// <summary>
    /// Déclaration de méthode généralisée de suppression pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à supprimer</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> supprimée</returns>
    public TEntity Delete(TEntity instance);

}
