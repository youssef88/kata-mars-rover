using System;
using Xunit;

namespace MarsRover.UnitTests
{
    public class MarsRoverShould
    {
        private const int PLATEAU_HEIGHT = 10;
        private const int PLATEAU_WIDTH = 10;

        private string MarsRoverExecute(string command)
        {
            Plateau plateau = new Plateau(PLATEAU_HEIGHT, PLATEAU_WIDTH);
            MarsRover marsRover = new MarsRover(plateau);
            return marsRover.Execute(command);

        }
        [Fact]
        public void BeAt00NWhenNoCommands ()
        {
            Assert.Equal("0:0:N", MarsRoverExecute(""));
        }

        [Fact]
        public void BeAt00EWhenRCommand()
        {
            Assert.Equal("0:0:E", MarsRoverExecute("R"));
        }
        [Fact]
        public void BeAt00WWhenLCommand()
        {
            Assert.Equal("0:0:W", MarsRoverExecute("L"));
        }
        
        [Fact]
        public void BeAt01NWhenMCommand()
        {
            Assert.Equal("0:1:N", MarsRoverExecute("M"));
        }
        [Fact]
        public void BeAt02NWhenMMCommand()
        {
            Assert.Equal("0:2:N", MarsRoverExecute("MM"));
        }
        [Fact]
        public void BeAt03NWhenMMMCommand()
        {
            Assert.Equal("0:3:N", MarsRoverExecute("MMM"));
        }


        [Fact]
        public void BeAt00SWhenRRCommand()
        {
            Assert.Equal("0:0:S", MarsRoverExecute("RR"));
        }

        [Fact]
        public void BeAt10EWhenRMCommand()
        {
            Assert.Equal("1:0:E", MarsRoverExecute("RM"));
        }

        [Fact]
        public void BeAt00NWhenMMMMMMMMMMCommand()
        {
            Assert.Equal("0:0:N", MarsRoverExecute("MMMMMMMMMM"));
        }

        [Fact]

        public void BeAt00NWhenRMMMMMMMMMMCommand()
        {
            Assert.Equal("0:0:E", MarsRoverExecute("RMMMMMMMMMM"));
        }



    }
}
