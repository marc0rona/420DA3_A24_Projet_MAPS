using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Enums;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class MedecinService {
    private readonly MedecinDAO medecinDAO;
    private readonly MedecinView medecinView;

    public MedecinService(ExempleApplication app, ExempleDbContext context) {
        this.medecinDAO = new MedecinDAO(context);
        this.medecinView = new MedecinView(app);
    }

    public void OpenViewFor(ViewActionsEnum viewAction, Medecin? medecin = null) {
        _ = this.medecinView.OpenFor(viewAction, medecin);
    }

    public List<Medecin> SearchMedecin(string filter) {
        return this.medecinDAO.SearchMedecin(filter);
    }

    public Medecin DoCreateMedecin(string nom, string prenom, int numLicenceMedicale) {
        Medecin nouveauMedecin = new Medecin(nom, prenom, numLicenceMedicale);
        return this.medecinDAO.CreateMedecin(nouveauMedecin);
    }

    public Medecin DoUpdateMedecin(Medecin medecin) {
        return this.medecinDAO.UpdateMedecin(medecin);
    }

    public void DoDeleteMedecin(Medecin medecin, bool softDeletes = true) {
        this.medecinDAO.DeleteMedecin(medecin, softDeletes);
    }

}
