using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.DataAccess.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess.SqlServer;
public class SqlServerDataProvider : AbstractDataProvider {

    public SqlServerDataProvider() : base(new SqlServerDataContext()) { }

}
