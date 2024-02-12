using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingPractise.Tests.Unit
{
    
    public class StudentServiceTests
    {
        [Fact]
        public void ShouldReturnFullNmaeByGettingFirstNameAndLastName()
        {

            //given
            var StudentService = new StudentService();
            var randomFirstName = "sachi";
           var randomLastName = "Buddhi";
            var expectedFullName = "sachi buddhi";


            //when
            var actualFullName = StudentService.CreateFullName(randomFirstName, randomLastName);

            //then
            Assert.Equal(expectedFullName,actualFullName,ignoreCase:true);
            //Assert.Matches("[a-z] [a-z]", actualFullName);

        }
    }
}
