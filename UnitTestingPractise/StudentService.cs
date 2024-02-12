using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractise
{
    public class StudentService
    {
        public String  CreateFullName(string FirstName,string LastName) 
        {
            return $"{FirstName} {LastName}";
        }
    }
}
