using MarsRover.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Command
{
    public class Invoker
    {
        public static ICommand GetCommand(CommandType commandType)
        {
            Dictionary<CommandType, ICommand> commands = new();
            commands.Add(CommandType.R, new TurnRight());
            commands.Add(CommandType.L, new TurnLeft());
            commands.Add(CommandType.M, new Move());

            return commands[commandType];
        }
    }
}