using FakeShipmentsLibrary.Internals.Abstracts;

namespace FakeShipmentsLibrary.Internals;
internal class FakePurolatorAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "PUR-" + IShipmentDataProvider.GenerateNumber();
    }

}
