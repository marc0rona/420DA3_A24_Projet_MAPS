using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class RendezVousService {
    private readonly RendezVousDAO rendezVousDAO;

    public RendezVousService(ExempleDbContext context) {
        this.rendezVousDAO = new RendezVousDAO(context);
    }

}
