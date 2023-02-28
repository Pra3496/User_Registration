using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Regexs
    {
       
        public void ValidateFirstName(string name)
        {
           
            string firstName = "^[A-Z][a-z]{3,}?";

            if(Regex.IsMatch(name,firstName))
            {
                Console.WriteLine("FirstName is Maching");
            }
            else
            {
                Console.WriteLine("FirstName is NOT Maching");
            }
        }

        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";

            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("LastName is Maching");
            }
            else
            {
                Console.WriteLine("LastName is NOT Maching");
            }
        }





    }
}
