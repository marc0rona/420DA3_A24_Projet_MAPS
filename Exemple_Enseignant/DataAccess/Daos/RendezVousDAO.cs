using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
internal class RendezVousDAO {
    private readonly ExempleDbContext context;

    public RendezVousDAO(ExempleDbContext context) {
        this.context = context;
    }


    public List<RendezVous> GetAllRendezVous() {
        return this.context.RendezVous.Where(rdv => rdv.DateDeleted == null).ToList();
    }

    public RendezVous? GetRendezVousById(int id) {
        return this.context.RendezVous
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv => rdv.Id == id
                && rdv.DateDeleted == null)
            .FirstOrDefault();
    }

    public List<RendezVous> SearchRendezVous(string filter) {
        return this.context.RendezVous
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv => (
                    rdv.Id.ToString().Contains(filter)
                    || rdv.Patient.Nom.Contains(filter)
                    || rdv.Patient.Prenom.Contains(filter)
                    || rdv.Medecin.Nom.Contains(filter)
                    || rdv.Medecin.Prenom.Contains(filter))
                    && rdv.DateDeleted == null)
            .ToList();
    }

    public List<RendezVous> GetRendezVousByPatient(Patient patient, bool includePastRdvs = false) {
        return this.context.RendezVous
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    rdv.Patient.Id == patient.Id
                    && includePastRdvs ? true : DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0
                    && rdv.DateDeleted == null
                )
            .ToList();
    }

    public List<RendezVous> GetRendezVousByMedecin(Medecin medecin, bool includePastRdvs = false) {
        return this.context.RendezVous
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    rdv.Medecin.Id == medecin.Id
                    && includePastRdvs ? true : DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0
                    && rdv.DateDeleted == null
                )
            .ToList();
    }

    public RendezVous CreateRendezVous(RendezVous rdv) {
        _ = this.context.RendezVous.Add(rdv);
        _ = this.context.SaveChanges();
        return rdv;
    }

    public RendezVous UpdateRendezVous(RendezVous rdv) {
        rdv.DateModified = DateTime.Now;
        _ = this.context.RendezVous.Update(rdv);
        _ = this.context.SaveChanges();
        return rdv;
    }

    public void DeleteRendezVous(RendezVous rdv, bool softDeletes = true) {
        if (softDeletes) {
            rdv.DateDeleted = DateTime.Now;
            _ = this.context.RendezVous.Update(rdv);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.RendezVous.Remove(rdv);
            _ = this.context.SaveChanges();
        }
    }

}
