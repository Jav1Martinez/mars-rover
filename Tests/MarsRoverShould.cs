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
        
        [Theory]
        [InlineData("R", "0:0:E")] // North to East
        [InlineData("RR", "0:0:S")] // East to South
        [InlineData("RRR", "0:0:W")] // South to West
        [InlineData("RRRR", "0:0:N")] // West to North
        public void RotateRight(string move, string expectedPosition)
        {
            // Act
            var result = new MarsRover.MarsRover().Execute(move);
            
            // Assert
            Assert.Equal(expectedPosition, result);
        }

        [Fact]
        public void MoveOneStepAheadInCoordinateYDirection()
        {
            // Assert
            var command = "M";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:1:N", result);
        }
    }
}