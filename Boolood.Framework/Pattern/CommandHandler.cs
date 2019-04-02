using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Framework.Core.Patterns;

namespace Boolood.Framework.Pattern
{
    public class CommandsHandler: ICommandsHandler
    {
        public CommandsHandler()
        {
            Commands = new List<Action>();
        }
        private List<Action> Commands { get; }

        public void AddCommand(Action saver)
        {
            Commands.Add(saver);
        }

        public void ExecuteAll()
        {
            Commands.ForEach(c => c.Invoke());
        }
    }
}
