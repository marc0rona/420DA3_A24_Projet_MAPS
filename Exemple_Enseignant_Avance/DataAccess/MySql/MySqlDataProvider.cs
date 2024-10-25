using Exemple_Enseignant_Avance.DataAccess.Abstractions;
using Exemple_Enseignant_Avance.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess.MySql;
public class MySqlDataProvider : AbstractDataProvider {

    public MySqlDataProvider() : base(new MySqlDataContext()) { }

}
