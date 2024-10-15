using Project_Utilities.Services.Abstracts;

namespace Project_Utilities.Services;
internal class FakePurolatorAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "PUR-" + IShipmentDataProvider.GenerateNumber();
    }

}
