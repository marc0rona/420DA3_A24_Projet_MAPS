using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.DataAccess.Abstractions;
public abstract class AbstractDao<TEntity, TEntityKey> : IDao<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : struct, IEquatable<TEntityKey> {

    protected readonly IDataContext Context;

    protected AbstractDao(IDataContext context) {
        this.Context = context;
    }


    public virtual TEntity Create(TEntity instance) {
        _ = this.Context.GetDbSet<TEntity>().Add(instance);
        _ = this.Context.SaveChanges();
        return instance;
    }

    public virtual List<TEntity> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? this.Context.GetDbSet<TEntity>().ToList()
            : this.Context.GetDbSet<TEntity>().Where(entity => entity.GetDateDeleted() == null).ToList();
    }

    public virtual TEntity? GetById(TEntityKey id, bool includeDeleted = false) {
        return includeDeleted
            ? this.Context.GetDbSet<TEntity>().Where(entity => entity.GetId().Equals(id)).FirstOrDefault()
            : this.Context.GetDbSet<TEntity>().Where(entity => entity.GetId().Equals(id) && entity.GetDateDeleted() == null).ToList().FirstOrDefault();
    }

    public virtual TEntity Update(TEntity instance) {
        instance.SetDateModified(DateTime.Now);
        _ = this.Context.GetDbSet<TEntity>().Update(instance);
        _ = (this.Context?.SaveChanges());
        return instance;
    }

    public virtual TEntity Delete(TEntity instance, bool softDeletes = true) {
        if (softDeletes) {
            instance.SetDateDeleted(DateTime.Now);
            _ = this.Context.GetDbSet<TEntity>().Update(instance);
            _ = this.Context.SaveChanges();
        } else {
            _ = this.Context.GetDbSet<TEntity>().Remove(instance);
            _ = this.Context.SaveChanges();
        }
        return instance;
    }
}
