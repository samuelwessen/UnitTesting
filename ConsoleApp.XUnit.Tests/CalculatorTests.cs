using System;
using Xunit;

namespace ConsoleApp.XUnit.Tests
{
    //TDD - Test Driven Development (Test First Then Code)
    //Enhetstest (Unit Test), Integrationtest (Integration Test), Början till slut test (End to End Test)
    //RED, GREEN, REFACT

    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            var _calc = new Calculator();
            Assert.Equal(expected, _calc.Add(value1, value2));
        }



        //[Fact]
        //public void Create_ShouldCreatePerson()
        //{
        //    var person = new Person();
        //    bool actual = person.Create();
        //    Assert.True(actual);
        //}
    }

    
}
