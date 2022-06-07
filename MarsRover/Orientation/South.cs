using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Orientation
{
    public class South : IOrientation
    {

        private readonly IPlateau _plateau;

        public South(IPlateau plateau)
        {
            _plateau = plateau;
        }
        public void MoveForward()
        {
            _plateau.MoveYBackward();
        }

        public IOrientation TurnLeft()
        {
            return new East(_plateau);
        }

        public IOrientation TurnRight()
        {
            return new West(_plateau);
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
