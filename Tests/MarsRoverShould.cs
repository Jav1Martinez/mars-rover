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

        [Theory]
        [InlineData("M", "0:1:N")]
        [InlineData("MM", "0:2:N")]
        [InlineData("MMMMMMMMM", "0:9:N")]
        public void MoveOneStepAheadInCoordinateYDirection(string command, string expectedResult)
        {
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact] 
        public void WrapAroundWhenCoordinateYisOverflowed()
        {
            // Arrange
            var command = "MMMMMMMMMM";
            
            //Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:N", result);
        }

        [Fact]
        public void WrapAroundWhenCoordianteYisUnderflowed()
        {
            // Arrange
            var command = "RRM";
            
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:9:S", result);
        }

        [Theory]
        [InlineData("RM", "1:0:E")]
        [InlineData("RMM", "2:0:E")]
        [InlineData("RMMMMMMMMM", "9:0:E")]
        public void MoveOneStepAheadInCoordinateXDirection(string command, string expectedResult)
        {
            // Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact] 
        public void WrapAroundWhenCoordinateXisOverflowed()
        {
            // Arrange
            var command = "RMMMMMMMMMM";
            
            //Act
            var result = new MarsRover.MarsRover().Execute(command);
            
            // Assert
            Assert.Equal("0:0:E", result);
        }
    }
}