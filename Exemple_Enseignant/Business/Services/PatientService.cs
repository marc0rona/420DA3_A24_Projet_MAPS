using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class PatientService {
    private readonly PatientDAO patientDAO;

    public PatientService(ExempleDbContext context) {
        this.patientDAO = new PatientDAO(context);
    }

}
