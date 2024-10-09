namespace _420DA3_A24_Exemple_Enseignant.Business.Domain;
internal class Medecin {
    public const int FIRSTNAME_MAX_LENGTH = 64;
    public const int LASTNAME_MAX_LENGTH = 64;
    public const int LICENSE_MAX_LENGTH = 16;

    // Propriétés des médecins
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int NumLicenseMedicale { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation EF Core
    // Ici l'inverse du Medecin / MedecinId dans RendezVous
    public List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();

    public Medecin(string nom, string prenom, int numLicenseMedicale) {
        this.Nom = nom;
        this.Prenom = prenom;
        this.NumLicenseMedicale = numLicenseMedicale;
    }

    private Medecin(
        int id,
        string nom,
        string prenom,
        int numLicenseMedicale,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(nom, prenom, numLicenseMedicale) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public override string ToString() {
        return $"#{this.Id} - {this.Nom}, {this.Prenom} - {this.NumLicenseMedicale}";
    }

}
