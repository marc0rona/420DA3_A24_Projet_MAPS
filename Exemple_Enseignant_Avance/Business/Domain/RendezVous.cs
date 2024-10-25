using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Domain;
public class RendezVous : AbstractEntity<int> {

    // Données du rendez-vous lui-même
    public DateTime DateRendezVous { get; set; }
    public int PatientId { get; set; }
    public int MedecinId { get; set; }


    // Propriétés de navigation EF Core
    // Une pour chaque propriété XxxxxId
    public virtual Patient Patient { get; set; } = null!;
    public virtual Medecin Medecin { get; set; } = null!;



    public RendezVous(DateTime dateRendezVous, int patientId, int medecinId) {
        this.DateRendezVous = dateRendezVous;
        this.PatientId = patientId;
        this.MedecinId = medecinId;
    }

    private RendezVous(int id,
        DateTime dateRendezVous,
        int patientId,
        int medecinId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)

        : this(dateRendezVous, patientId, medecinId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public override string ToString() {
        return $"#{this.Id} le {this.DateRendezVous:dd MMM yyyy à HH:mm} - {this.Patient.Nom}, {this.Patient.Prenom} avec Dr. {this.Medecin.Nom}";
    }

}
