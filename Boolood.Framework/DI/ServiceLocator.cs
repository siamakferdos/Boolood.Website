using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Framework.Core;

namespace Boolood.Framework.DI
{
    public class ServiceLocator
    {
        public ServiceLocator(IDiContainer container)
        {
            Current = container;
        }

        public static IDiContainer Current
        {
            get;
            private set;
        }
    }
}
