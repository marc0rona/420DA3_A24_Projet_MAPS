using Project_Utilities.Services.Abstracts;

namespace Project_Utilities.Services;
internal class FakeFedExAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "FDX-" + IShipmentDataProvider.GenerateNumber();
    }

}
