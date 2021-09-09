using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        
        
        [Fact]
        public void IsLeapYearTrue()
        {
            // arrange
            var year = new Methods();
            // act
            bool result = year.IsLeapYear(1600);
            // assert 
            Assert.True(result);
        }
        [Fact]
        public void IsLeapYearFalse()
        {
            // arrange
            var year = new Methods();
            // act
            bool result = year.IsLeapYear(1700);
            // assert 
            Assert.False(result);
        }
        [Fact]
        public void IsLeapYearLessThan1582()
        {
            // arrange
            var year = new Methods();
            // act
            bool result = year.IsLeapYear(1400);
            // assert 
            Assert.False(result);
        }
        [Fact]
        public void IsLeapYearDivisableBy4And100()
        {
            // arrange
            var year = new Methods();
            // act
            bool result = year.IsLeapYear(2000);
            // assert 
            Assert.True(result);
        }
    }
}
