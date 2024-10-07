using FakeShipmentsLibrary.Internals.Abstracts;

namespace FakeShipmentsLibrary.Internals;
internal class FakeFedExAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "FDX-" + IShipmentDataProvider.GenerateNumber();
    }

}
