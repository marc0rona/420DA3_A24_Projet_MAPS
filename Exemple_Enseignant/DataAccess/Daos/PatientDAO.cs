using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
internal class PatientDAO {
    private readonly ExempleDbContext context;

    public PatientDAO(ExempleDbContext context) {
        this.context = context;
    }

    public List<Patient> GetAll() {
        return this.context.Patients.Where(patient => patient.DateDeleted == null).ToList();
    }

    public Patient? GetById(int id) {
        return this.context.Patients.Where(
            patient => patient.Id == id
            && patient.DateDeleted == null
            ).FirstOrDefault();
    }

    public List<Patient> Search(string filter) {
        return this.context.Patients.Where(
            patient => (
                patient.Nom.Contains(filter)
                || patient.Prenom.Contains(filter)
                || patient.NumAssMaladie.Contains(filter)
            )
            && patient.DateDeleted == null
            ).ToList();
    }

    public Patient Create(Patient patient) {
        _ = this.context.Patients.Add(patient);
        _ = this.context.SaveChanges();
        return patient;
    }

    public Patient Update(Patient patient) {
        patient.DateModified = DateTime.Now;
        _ = this.context.Patients.Update(patient);
        _ = this.context.SaveChanges();
        return patient;
    }

    public void Delete(Patient patient, bool softDeletes = true) {
        if (softDeletes) {
            patient.DateDeleted = DateTime.Now;
            _ = this.context.Patients.Update(patient);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Patients.Remove(patient);
            _ = this.context.SaveChanges();
        }
    }

}
