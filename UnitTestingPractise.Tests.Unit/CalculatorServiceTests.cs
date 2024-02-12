using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingPractise.Tests.Unit
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void ShouldInputTwoIntsAndAddThemReturnInt()
        {
     
            //given
            var calcService = new CalculatorService();
            var randomIntA = 2;
            var randomIntB = 5;
            var expectedValue = 7;

            //when
            var actualValue = calcService.AddTwoInts(randomIntA, randomIntB);

            //then
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
