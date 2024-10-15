using Project_Utilities.Services.Abstracts;

namespace Project_Utilities.Services.APIs;
internal class FakeFedExAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "FDX-" + IShipmentDataProvider.GenerateNumber();
    }

}
