using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.DataAccess.Abstractions;
public abstract class AbstractDao<TEntity, TEntityKey> : IDao<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : struct, IEquatable<TEntityKey> {

    private AbstractDbContext context;

    protected AbstractDao(AbstractDbContext context) {
        this.context = context;
    }


    public virtual TEntity Create(TEntity instance) {
        this.context.GetDbSet<TEntity>().Add(instance);
        this.context.SaveChanges();
        return instance;
    }

    public virtual List<TEntity> GetAll() {
        return this.context.GetDbSet<TEntity>().ToList();
    }

    public virtual TEntity? GetById(TEntityKey id) {
        return this.context?.GetDbSet<TEntity>().Where(entity => entity.GetId().Equals(id)).FirstOrDefault();
    }

    public virtual TEntity Update(TEntity instance) {
        this.context.GetDbSet<TEntity>().Update(instance);
        this.context?.SaveChanges();
        return instance;
    }

    public virtual TEntity Delete(TEntity instance) {
        this.context.GetDbSet<TEntity>().Remove(instance);
        this.context?.SaveChanges();
        return instance;
    }
}
