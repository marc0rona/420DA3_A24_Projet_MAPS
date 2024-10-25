using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business.Abstractions;
public interface IDataProvider {

    public IPatientDAO GetPatientDao();

    public IMedecinDAO GetMedecinDao();

    public IRendezVousDAO GetRendezVousDao();

}
