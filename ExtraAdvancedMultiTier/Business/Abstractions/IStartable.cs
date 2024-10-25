using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IStartable {

    public delegate void StartableEventHandler(IStartable startable);
    public event StartableEventHandler? Starting;
    public event StartableEventHandler? Started;

    public void Start();

}
