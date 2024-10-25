using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IDataContext {
    public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class;

}
