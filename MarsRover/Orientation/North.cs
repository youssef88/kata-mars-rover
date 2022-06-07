using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Orientation
{
    public class North : IOrientation
    {

        private readonly IPlateau _plateau;

        public North(IPlateau plateau)
        {
            _plateau = plateau;
        }
        public void MoveForward()
        {
            _plateau.MoveYForward();
        }

        public IOrientation TurnLeft()
        {
            return new West(_plateau);
        }

        public IOrientation TurnRight()
        {
            return new East(_plateau);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
