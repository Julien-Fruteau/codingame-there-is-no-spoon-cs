using System;
using Xunit;

namespace codingame_there_is_no_spoon_cs.test
{
    public class PlayerTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Grid grid = new Grid(4, 2);

            // Act
            grid.AddLine("0000");
            grid.AddLine("0..0");

            // Assert
            string coorVal = grid.GetCoorValue(0,0);
            Assert.Equal("0", coorVal.ToString());
        }
    }
}
