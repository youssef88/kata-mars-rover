using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IPlateau
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        void MoveXForward();
        void MoveXBackward();
        void MoveYForward();
        void MoveYBackward();
    }
}
