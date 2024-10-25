namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractException<TCode> : Exception {

    public TCode? Code { get; private set; }

    public AbstractException(string? message = null, TCode? code = default(TCode), Exception? innerException = null) : base(message, innerException) {
        this.Code = code;
    }

}
