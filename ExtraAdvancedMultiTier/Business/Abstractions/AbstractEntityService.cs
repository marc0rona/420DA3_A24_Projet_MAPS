using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractEntityService<TEntity, TEntityKey> : AbstractService 
    where TEntity : class, IEntity<TEntityKey> 
    where TEntityKey : IEquatable<TEntityKey> {

    protected AbstractEntityService(IServiceContainer parent) : base(parent) { }


}
