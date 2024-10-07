namespace FakeShipmentsLibrary.Internals.Abstracts;
internal interface IShipmentDataProvider {

    public string GetTrackingNumber();

    protected static string GenerateNumber() {
        return DateTime.Now.ToString("yyyyMMddHHmmss");
    }

}
