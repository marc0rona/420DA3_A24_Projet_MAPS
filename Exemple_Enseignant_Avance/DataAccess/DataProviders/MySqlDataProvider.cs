using Exemple_Enseignant_Avance.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess.DataProviders;
public class MySqlDataProvider : AbstractDataProvider
{

    public MySqlDataProvider() : base(new MySqlDataContext()) { }

}
