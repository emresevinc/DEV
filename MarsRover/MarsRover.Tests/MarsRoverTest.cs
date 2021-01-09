using Mars_Rover;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverTest
    { 
        [Fact]
        public void GetLastCooardinate_Correct1()
        {
            char[] upperRigth = { '5', '5' };
            char[] roverPosition = { '1','2','N' };
            char[] moveAction = "LMLMLMLMM".ToCharArray();
            var tuple = MarsRoverOperation.GetLastCooardinate(roverPosition, moveAction);
            Assert.Equal(Tuple.Create(1,3,'N'), tuple);
        }

        [Fact]
        public void GetLastCooardinate_Correct2()
        {
            char[] upperRigth = { '5', '5' };
            char[] roverPosition = { '3', '3', 'E' };
            char[] moveAction = "MMRMMRMRRM".ToCharArray();
            var tuple = MarsRoverOperation.GetLastCooardinate(roverPosition, moveAction);
            Assert.Equal(Tuple.Create(5, 1, 'E'), tuple);
        }

        [Fact]
        public void GetLastCooardinate_Correct3()
        {
            char[] upperRigth = { '5', '5' };
            char[] roverPosition = { '3', '3', 'E' };
            char[] moveAction = "MMRMMRMRRMLM".ToCharArray();
            var tuple = MarsRoverOperation.GetLastCooardinate(roverPosition, moveAction);
            Assert.Equal(Tuple.Create(5, 2, 'N'), tuple);
        }

        [Fact]
        public void ValidatePlateuUpperRightCoordinates_IncorrectInputLength()
        {
            string[] input = { "5", "5", "1" };
            Action act = () => MarsRoverOperation.ValidatePlateuUpperRightCoordinates(input);
            Assert.Throws<FormatException>(act);
        }

        [Fact]
        public void ValidatePlateuUpperRightCoordinates_IncorrectInputValue()
        {
            string[] input = { "5", "X", "1" };
            Action act = () => MarsRoverOperation.ValidatePlateuUpperRightCoordinates(input);
            Assert.Throws<FormatException>(act);
        }

        [Fact]
        public void ValidatePlateuUpperRightCoordinates_Correct()
        {
            string[] input = { "5", "5" };
            Action act = () => MarsRoverOperation.ValidatePlateuUpperRightCoordinates(input);
            Assert.True(true);
        }

        [Fact]
        public void ValidateRoverPosition_IncorrectInputValue()
        {
            char[] input = { '5', '1', 'Z', '1' };
            Action act = () => MarsRoverOperation.ValidateRoverPosition(input);
            Assert.Throws<FormatException>(act);
        }

        [Fact]
        public void ValidateRoverPosition_Correct()
        {
            char[] input = { '1', '1', 'N' };
            Action act = () => MarsRoverOperation.ValidateRoverPosition(input);
            Assert.True(true);
        }

        [Fact]
        public void ValidateMoveActions_IncorrectInputValue()
        {
            char[] input = { 'L', 'R', 'M', 'Z' };
            Action act = () => MarsRoverOperation.ValidateMoveActions(input);
            Assert.Throws<FormatException>(act);
        }
    }
}
