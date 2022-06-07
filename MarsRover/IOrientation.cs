using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IOrientation
    {
        IOrientation TurnLeft();
        IOrientation TurnRight();
        void MoveForward();


    }
}
