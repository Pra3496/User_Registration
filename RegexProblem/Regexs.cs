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

       


       
    }
}
