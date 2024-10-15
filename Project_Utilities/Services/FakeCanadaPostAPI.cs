using Project_Utilities.Services.Abstracts;

namespace Project_Utilities.Services;
internal class FakeCanadaPostAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "CAN-" + IShipmentDataProvider.GenerateNumber();
    }
}
