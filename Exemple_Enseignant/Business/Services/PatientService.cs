using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Enums;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class PatientService {
    private readonly PatientDAO dao;
    private readonly PatientView view;

    public PatientService(ExempleApplication app, ExempleDbContext context) {
        this.dao = new PatientDAO(context);
        this.view = new PatientView(app);
    }

    public void OpenViewFor(ViewActionsEnum viewAction, Patient? patient = null) {
        _ = this.view.OpenFor(viewAction, patient);
    }

    public List<Patient> Search(string filter) {
        return this.dao.Search(filter);
    }

    public Patient Create(Patient patient) {
        try {
            return this.dao.Create(patient);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Patient].", ex);
        }
    }

    public Patient? GetById(int id) {
        return this.dao.GetById(id);
    }

    public Patient Update(Patient patient) {
        try {
            return this.dao.Update(patient);
        } catch (Exception ex) {
            throw new Exception("Failed to update [Patient] instance.", ex);
        }
    }

    public void Delete(Patient patient, bool softDeletes = true) {
        try {
            this.dao.Delete(patient, softDeletes);
        } catch (Exception ex) {
            throw new Exception("Failed to delete [Patient] instance.", ex);
        }
    }

}
