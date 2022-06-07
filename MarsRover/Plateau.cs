using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau : IPlateau
    {
        public readonly int Height, Width;
        private int _x, _y = 0;
        public Plateau(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int CoordinateX => _x;

        public int CoordinateY => _y;



        public void MoveXBackward()
        {
            _x = _x - 1 == -1 ? Width - 1 : _x - 1;

        }

        public void MoveXForward()
        {
            _x = _x + 1 == Width ? 0 : _x + 1;
        }

        public void MoveYBackward()
        {
            _y = _y - 1 == -1 ? Height - 1 : _y - 1;
        }

        public void MoveYForward()
        {
            _y = _y + 1 == Height ? 0 : _y + 1;
        }
    }
}
