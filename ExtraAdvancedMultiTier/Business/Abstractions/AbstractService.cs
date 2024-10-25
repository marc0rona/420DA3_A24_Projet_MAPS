using ExtraAdvancedMultiTier.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExtraAdvancedMultiTier.Business.Abstractions.IService;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractService : IService {
    protected IServiceContainer? Parent {  get; set; }

    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;


    protected AbstractService(IServiceContainer? parent = null) { 
        parent?.RegisterService(this);
        this.Parent = parent;
        this.Started += this.OnStarting;
        this.Stopped += this.OnStopping;
        this.Started += this.OnStarted;
        this.Stopped += this.OnStopped;
    }

    public virtual void Start() {
        this.Starting?.Invoke(this);
        // Do something?
        this.Started?.Invoke(this);
    }

    public virtual void Stop() {
        this.Stopping?.Invoke(this);
        // Do something?
        this.Stopped?.Invoke(this);
    }

    public virtual IServiceContainer? GetParent() {
        return this.Parent;
    }

    public virtual T? GetParent<T>() where T : class, IServiceContainer {
        return this.Parent as T;
    }

    private void OnStarting(IStartable startable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStarted(IStartable startable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStopping(IStoppable stoppable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStopped(IStoppable stoppable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

}
