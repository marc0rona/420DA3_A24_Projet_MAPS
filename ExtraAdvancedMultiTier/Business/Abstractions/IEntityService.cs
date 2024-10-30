using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IEntityService<TEntity, TKey> : IService
    where TEntity : class, IEntity<TKey>
    where TKey : IEquatable<TKey> {

    public abstract IDao<TEntity, TKey> Dao { get; }

    public List<TEntity> GetAll();

    public TEntity? GetById(TKey id);

    public TEntity Create(TEntity entity);

    public TEntity Update(TEntity entity);

    public TEntity Delete(TEntity entity, bool softDeletes = true);

}
