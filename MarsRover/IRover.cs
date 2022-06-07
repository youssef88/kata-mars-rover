using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IRover
    {
        void TurnLeft();
        void TurnRight();
        void MoveForward();
    }
}
