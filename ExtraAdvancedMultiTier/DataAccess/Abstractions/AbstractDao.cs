using ExtraAdvancedMultiTier.Business.Abstractions;

namespace ExtraAdvancedMultiTier.DataAccess.Abstractions;
public abstract class AbstractDao<EntityType, EntityIdType> : IDao<EntityType, EntityIdType>
    where EntityType : class, IEntity<EntityIdType>
    where EntityIdType : struct, IEquatable<EntityIdType> {



    public EntityType Create(EntityType instance) {
        throw new NotImplementedException();
    }

    public EntityType Delete(EntityType instance) {
        throw new NotImplementedException();
    }

    public List<EntityType> GetAll() {
        throw new NotImplementedException();
    }

    public EntityType? GetById(EntityType id) {
        throw new NotImplementedException();
    }

    public EntityType Update(EntityType instance) {
        throw new NotImplementedException();
    }
}
