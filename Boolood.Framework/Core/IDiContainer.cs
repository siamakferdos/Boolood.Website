using System;
using System.Collections.Generic;
using System.Text;

namespace Boolood.Framework.Core
{
    public interface IDiContainer
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();
    }
}
