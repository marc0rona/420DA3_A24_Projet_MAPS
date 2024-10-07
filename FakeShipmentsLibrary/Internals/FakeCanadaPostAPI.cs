using FakeShipmentsLibrary.Internals.Abstracts;

namespace FakeShipmentsLibrary.Internals;
internal class FakeCanadaPostAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "CAN-" + IShipmentDataProvider.GenerateNumber();
    }
}
