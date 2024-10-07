using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class MedecinService {
    private readonly MedecinDAO medecinDAO;
    
    public MedecinService(ExempleDbContext context) { 
        this.medecinDAO = new MedecinDAO(context);
    }

}
