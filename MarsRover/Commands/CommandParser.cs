using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    public class CommandParser
    {
        public IRoverCommand ParseCommand(char command)
        {

            if (command == 'M')
            {
                return new MoveForwardCommand();
            }
            if (command == 'R')
            {
                return new RightCommand();
            }
            if (command == 'L')
            {
                return new LeftCommand();
            }
            return new NotFoundCommand();
        }
    }
}
