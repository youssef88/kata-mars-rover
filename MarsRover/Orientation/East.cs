using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Orientation
{
    public class East : IOrientation
    {

        private readonly IPlateau _plateau;

        public East(IPlateau plateau)
        {
            _plateau = plateau;
        }
        public void MoveForward()
        {
            _plateau.MoveXForward();
        }

        public IOrientation TurnLeft()
        {
            return new North(_plateau);
        }

        public IOrientation TurnRight()
        {
            return new South(_plateau);
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
