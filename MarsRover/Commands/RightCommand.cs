using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    public class RightCommand : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}
