using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.DataAccess.Contexts;
using Exemple_Enseignant_Avance.DataAccess.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess.DataProviders;
public class AbstractDataProvider : IDataProvider
{
    private readonly IMedecinDAO medecinDao;
    private readonly IPatientDAO patientDao;
    private readonly IRendezVousDAO rdvDao;

    protected AbstractDataProvider(AbstractAdvancedExampleContext context)
    {
        this.medecinDao = new MedecinDAO(context);
        this.patientDao = new PatientDAO(context);
        this.rdvDao = new RendezVousDAO(context);
    }

    public IMedecinDAO GetMedecinDao()
    {
        return this.medecinDao;
    }

    public IPatientDAO GetPatientDao()
    {
        return this.patientDao;
    }

    public IRendezVousDAO GetRendezVousDao()
    {
        return this.rdvDao;
    }
}
