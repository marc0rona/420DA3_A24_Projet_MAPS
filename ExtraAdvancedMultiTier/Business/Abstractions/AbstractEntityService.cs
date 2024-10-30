using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractEntityService<TEntity, TEntityKey> : AbstractService, IEntityService<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : IEquatable<TEntityKey> {

    protected AbstractEntityService(IServiceContainer parent)
        : base(parent) { }


    public abstract IDao<TEntity, TEntityKey> Dao { get; }

    public TEntity Create(TEntity entity) {
        return this.Dao.Create(entity);
    }

    public List<TEntity> GetAll() {
        return this.Dao.GetAll();
    }

    public TEntity? GetById(TEntityKey id) {
        return this.Dao.GetById(id);
    }

    public TEntity Update(TEntity entity) {
        return this.Dao.Update(entity);
    }

    public TEntity Delete(TEntity entity, bool softDeletes = true) {
        return this.Dao.Delete(entity, softDeletes);
    }
}
