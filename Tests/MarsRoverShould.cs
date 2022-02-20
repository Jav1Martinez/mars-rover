using Xunit;

namespace Tests
{
    public class MarsRoverShould
    {
        [Theory]
        [InlineData("L", "0:0:W")] // North to West
        [InlineData("LL", "0:0:S")] // West to South
        [InlineData("LLL", "0:0:E")] // South to East
        [InlineData("LLLL", "0:0:N")] // East to North
        public void RotateLeft(string move, string expectedPosition)
        {
            // Act
            var result = new MarsRover.MarsRover().Execute(move);

            // Assert
            Assert.Equal(expectedPosition, result);
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
        
        [Fact]
        public void RotateRightFromEast_ThenSouthIsFacing()
        {
            // Arrange
            var command = "RR";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:S", result);
        }
    }
}