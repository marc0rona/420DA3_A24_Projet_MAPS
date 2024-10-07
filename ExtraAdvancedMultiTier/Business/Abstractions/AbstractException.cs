namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractException<TCode> : Exception {

    public TCode? Code { get; private set; }

    public AbstractException() : base() { }

    public AbstractException(string message) : base(message) { }

    public AbstractException(string message, TCode code) : base(message) {
        this.Code = code;
    }

    public AbstractException(string message, Exception innerException) : base(message, innerException) { }

    public AbstractException(string message, TCode? code, Exception innerException) : base(message, innerException) {
        this.Code = code;
    }

}
