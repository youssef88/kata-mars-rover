using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    public class MoveForwardCommand : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveForward();
        }
    }
}
