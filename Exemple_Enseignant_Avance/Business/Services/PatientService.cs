using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.DataAccess.Daos;
using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Services;

class PatientService : AbstractEntityService<Patient, int> {
    public override PatientDAO Dao { get; }

    public PatientService(IServiceContainer parent, IDataContext context)
        : base(parent) {
        this.Dao = new PatientDAO(context);
    }

    /*
     * MÉTHODES:
     * - GetAll()
     * - GetById(int)
     * - Create(Patient)
     * - Update(Patient)
     * - Delete(Patient, bool)
     * 
     * Automatiquement héritées de AbstractEntityService
     */

}
