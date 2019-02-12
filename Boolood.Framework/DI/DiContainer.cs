using System;
using System.Collections.Generic;
using Boolood.Framework.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Boolood.Framework.DI
{
    public class DiContainer: IDiContainer
    {
        private static IServiceProvider _container;

        public DiContainer(IServiceProvider container)
        {
            _container = container;
        }

        public T Resolve<T>()
        {
            return _container.GetService<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container.GetServices<T>();
        }
    }
}
