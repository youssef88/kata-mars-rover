using MarsRover.Commands;
using MarsRover.Orientation;
using System;

namespace MarsRover
{
    public class MarsRover: IRover
    {
        private readonly IPlateau _plateau;
        public IOrientation Orientation { get; private set; }

        public MarsRover(IPlateau plateau)
        {
            _plateau = plateau;
            Orientation = new North(_plateau); //fixed for now
        }

        public string Execute(string command)
        {
            CommandParser commandParser = new CommandParser();
            foreach (char cmd in command)
            {

                IRoverCommand commandToExecute = commandParser.ParseCommand(cmd);
                commandToExecute.Execute(this);
            }
            
            return PrintState();
           
        }

        public void TurnLeft()
        {
            Orientation = Orientation.TurnLeft();

        }

        public void TurnRight()
        {
            Orientation = Orientation.TurnRight();

        }

        public void MoveForward()
        {
            Orientation.MoveForward();

        }


        public int CoordinateX
        {
            get { return _plateau.CoordinateX; }
        }

        public int CoordinateY
        {
            get { return _plateau.CoordinateY; }
        }

        private string PrintState()
        {
            return $"{CoordinateX}:{CoordinateY}:{Orientation}";
        }

    }
}
