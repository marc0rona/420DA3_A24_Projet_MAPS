using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Extras.Abstractions;
public interface IEntity<TIdentifier>
{

    TIdentifier? GetId();
    DateTime? GetDateCreated();
    DateTime? GetDateModified();
    DateTime? GetDateDeleted();
    bool IsDeleted();

}
