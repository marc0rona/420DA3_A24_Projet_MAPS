using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
internal class RendezVousDAO {
    private readonly ExempleDbContext context;

    public RendezVousDAO(ExempleDbContext context) {
        this.context = context;
    }


}
