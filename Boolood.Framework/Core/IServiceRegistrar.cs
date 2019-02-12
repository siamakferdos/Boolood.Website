using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Boolood.Framework.Core
{
    public interface IServiceRegistrar
    {
        void Register(IServiceCollection container);
    }
}
