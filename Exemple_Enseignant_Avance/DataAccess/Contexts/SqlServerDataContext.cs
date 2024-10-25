using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess.Contexts;
internal class SqlServerDataContext : AbstractAdvancedExampleContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_projet_exemple_enseignant_avance;Integrated Security=true;TrustServerCertificate=true;");
    }

}
