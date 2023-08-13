using prj05_01.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class OperationsShould
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(-1, 1)]
        public void ValidateSquareInt(int number, int square)
        {
            // Arrange
            var sut = new Operations();
            // Act
            var actual = sut.Square(number);
            // Assert
            Assert.Equal(expected: square, actual: actual);
        }
    }
}
