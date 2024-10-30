using Project_Utilities.Enums;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IEntityView<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : IEquatable<TEntityKey> {

    protected abstract IEntityService<TEntity, TEntityKey> Service { get; }
    protected TEntity? CurrentInstance { get; set; }
    protected ViewActionsEnum CurrentAction { get; set; }
}
