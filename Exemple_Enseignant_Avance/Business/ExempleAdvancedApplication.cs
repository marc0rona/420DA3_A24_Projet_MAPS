using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Services;
using Exemple_Enseignant_Avance.DataAccess;
using ExtraAdvancedMultiTier.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business;
internal class ExempleAdvancedApplication : AbstractApplication {

    public ExempleAdvancedApplication() {
        _ = new DataProviderService(this);
    }

    public override void Start() {
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            service.Start();
        }
        this.TriggerStartedEvent();
    }

    public void Test() {
        IDataProvider dp = this.GetService<DataProviderService>()?.GetDataProvider(this.Configurations) ?? throw new Exception();
    }

}
