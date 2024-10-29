﻿using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.DataAccess.Contexts;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;
internal class PatientDAO : AbstractDao<Patient, int>, IPatientDAO {

    public PatientDAO(AbstractAdvancedExampleContext context) : base(context) { }

    public List<Patient> Search(string filter) {
        return this.Context.GetDbSet<Patient>().Where(
            patient => (
                patient.Nom.Contains(filter)
                || patient.Prenom.Contains(filter)
                || patient.NumAssMaladie.Contains(filter)
            )
            && patient.DateDeleted == null
            ).ToList();
    }

}
