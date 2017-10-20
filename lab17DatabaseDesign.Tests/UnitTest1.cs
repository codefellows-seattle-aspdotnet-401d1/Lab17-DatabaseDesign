using System;
using Xunit;
using lab17DatabaseDesign.Controllers;
using lab17DatabaseDesign.Models;

namespace lab17DatabaseDesign.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DestinationsContainsCurrency()
        {
            //Arrange
            var d = new Destinations();

            //Act
            d.Currncy = "Money";

            //Assert
            Assert.Contains(d.Currncy, "Money");

        }
    }
}
