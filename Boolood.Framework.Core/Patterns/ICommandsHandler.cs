using System;
using System.Collections.Generic;
using System.Text;

namespace Boolood.Framework.Core.Patterns
{
    public interface ICommandsHandler
    {
        void AddCommand(Action saver);
        void ExecuteAll();
    }
}
