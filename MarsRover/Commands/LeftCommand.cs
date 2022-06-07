using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    public class LeftCommand : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}
