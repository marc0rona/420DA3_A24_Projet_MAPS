namespace _420DA3_A24_Exemple_Enseignant.Business.Domain;
internal class Patient {
    public const int FIRSTNAME_MAX_LENGTH = 64;
    public const int LASTNAME_MAX_LENGTH = 64;
    public const int ASSNUMBER_MAX_LENGTH = 12;

    // Propriétés des patients
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NumAssMaladie { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation EF Core
    // Ici l'inverse du Patient / PatientId dans RendezVous
    public virtual List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();


    public Patient(string nom, string prenom, string numAssMaladie) : base() {
        this.Nom = nom;
        this.Prenom = prenom;
        this.NumAssMaladie = numAssMaladie;
    }

    private Patient(
        int id,
        string nom,
        string prenom,
        string numAssMaladie,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(nom, prenom, numAssMaladie) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }


    public override string ToString() {
        return $"#{this.Id} - {this.Nom}, {this.Prenom} - {this.NumAssMaladie}";
    }

}
