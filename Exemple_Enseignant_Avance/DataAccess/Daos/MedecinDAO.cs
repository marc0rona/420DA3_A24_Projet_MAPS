using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.DataAccess.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;
internal class MedecinDAO : AbstractDao<Medecin, int>, IMedecinDAO {

    public MedecinDAO(AbstractExempleAvanceContext context) : base(context) { }


    public List<Medecin> Search(string filter) {
        List<Medecin> results = this.Context.GetDbSet<Medecin>().Where(doc =>
            (
                doc.Nom.Contains(filter)
                || doc.Prenom.Contains(filter)
                || doc.NumLicenseMedicale.ToString().Contains(filter)
            )
            && doc.DateDeleted == null
        ).ToList();
        return results;
    }
}
