using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string str = string.Empty;

            //Act
            str = "monnaung";

            //Assert
            Assert.True(str == "monnaung");

        }

    }
}
