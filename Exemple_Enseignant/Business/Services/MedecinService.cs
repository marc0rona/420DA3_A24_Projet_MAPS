using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class MedecinService {
    private readonly MedecinDAO medecinDAO;
    private readonly MedecinView medecinView;

    public MedecinService(ExempleApplication app, ExempleDbContext context) {
        this.medecinDAO = new MedecinDAO(context);
        this.medecinView = new MedecinView(app);
    }

    public void OpenWindowForCreation() {
        _ = this.medecinView.OpenForCreation();
    }

    public void OpenWindowForVisualization(Medecin medecin) {
        this.medecinView.OpenForVisualization(medecin);
    }

    public void OpenWindowForEdition(Medecin medecin) {
        this.medecinView.OpenForEdition(medecin);
    }

    public void OpenWindowForSuppression(Medecin medecin) {
        this.medecinView.OpenForDeletion(medecin);
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
