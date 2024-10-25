using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.DataAccess.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;
internal class RendezVousDAO : AbstractDao<RendezVous, int>, IRendezVousDAO {

    public RendezVousDAO(AbstractExempleAvanceContext context) : base(context) { }


    public List<RendezVous> Search(string filter) {
        return this.Context.GetDbSet<RendezVous>()
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

    public List<RendezVous> GetByPatient(Patient patient, bool includePastRdvs = false) {
        return this.Context.GetDbSet<RendezVous>()
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    (rdv.Patient.Id == patient.Id
                    && includePastRdvs) || (DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0
                    && rdv.DateDeleted == null)
                )
            .ToList();
    }

    public List<RendezVous> GetByMedecin(Medecin medecin, bool includePastRdvs = false) {
        return this.Context.GetDbSet<RendezVous>()
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    (rdv.Medecin.Id == medecin.Id
                    && includePastRdvs) || (DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0
                    && rdv.DateDeleted == null)
                )
            .ToList();
    }

}
