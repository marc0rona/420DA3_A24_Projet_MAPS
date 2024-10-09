namespace _420DA3_A24_Exemple_Enseignant.Business.Domain;
internal class RendezVous {


    // Identifiant
    public int Id { get; set; }

    // Données du rendez-vous lui-même
    public DateTime DateRendezVous { get; set; }
    public int PatientId { get; set; }
    public int MedecinId { get; set; }

    // Méta-données
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation EF Core
    // Une pour chaque propriété XxxxxId
    public Patient Patient { get; set; } = null!;
    public Medecin Medecin { get; set; } = null!;



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
        return $"#{this.Id} le {this.DateRendezVous.ToString("dd MMM yyyy à HH:mm")} - {this.Patient.Nom}, {this.Patient.Prenom} avec Dr. {this.Medecin.Nom}";
    }

}
