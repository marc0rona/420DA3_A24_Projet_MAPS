using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
internal class PatientDAO {
    private readonly ExempleDbContext context;

    public PatientDAO(ExempleDbContext context) {
        this.context = context;
    }


}
