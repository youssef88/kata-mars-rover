using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Orientation
{
    public class West : IOrientation
    {

        private readonly IPlateau _plateau;

        public West(IPlateau plateau)
        {
            _plateau = plateau;
        }
        public void MoveForward()
        {
            _plateau.MoveXBackward();
        }

        public IOrientation TurnLeft()
        {
            return new South(_plateau);
        }

        public IOrientation TurnRight()
        {
            return new North(_plateau);
        }
        public override string ToString()
        {
            return "W";
        }
    }
}
