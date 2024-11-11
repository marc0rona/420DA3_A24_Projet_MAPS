using ExtraAdvancedMultiTier.Presentation;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public class AbstractFacade : AbstractDefaultExceptionHandler, IFacade {

    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;

    protected readonly IFacadeContainer Parent;


    public AbstractFacade(IFacadeContainer parent) : base() {
        this.Parent = parent;
        this.Parent.RegisterFacade(this);
    }

    public IFacadeContainer? GetParent() {
        throw new NotImplementedException();
    }

    public bool IsStarted() {
        throw new NotImplementedException();
    }

    public bool IsStopped() {
        throw new NotImplementedException();
    }

    public void RegisterService(IService service) {
        throw new NotImplementedException();
    }

    public void Start() {
        throw new NotImplementedException();
    }

    public void Stop() {
        throw new NotImplementedException();
    }

    T? IFacade.GetParent<T>() where T : class {
        throw new NotImplementedException();
    }

    T IServiceContainer.GetService<T>() {
        throw new NotImplementedException();
    }
}
