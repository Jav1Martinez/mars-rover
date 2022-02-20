using Xunit;

namespace Tests
{
    public class MarsRoverShould
    {
        [Fact]
        public void RotateLeftFromNorth_ThenWestIsFacing()
        {
            // Arrange
            var command = "L";

            // Act
            var result = new MarsRover.MarsRover().Execute(command);

            // Assert
            Assert.Equal("0:0:W", result);
        }

        [Fact]
        public void RotateLeftFromWest_ThenSouthIsFacing()
        {
            // Arrange
            var command = "LL";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:S", result);
        }

        [Fact]
        public void RotateLeftFromSouth_ThenEastIsFacing()
        {
            // Arrange
            var command = "LLL";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:E", result);
        }
        
        [Fact]
        public void RotateRightFromNorth_ThenEastIsFacing()
        {
            // Arrange
            var command = "R";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:E", result);
        }
    }
}