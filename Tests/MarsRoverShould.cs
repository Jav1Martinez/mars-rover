using Xunit;

namespace Tests
{
    public class MarsRoverShould
    {
        [Fact]
        public void WhenRotateLeftFromNorth_ThenWestIsFacing()
        {
            // Arrange
            var command = "L";

            // Act
            var result = new MarsRover.MarsRover().Execute(command);

            // Assert
            Assert.Equal("0:0:W", result);
        }
    }
}