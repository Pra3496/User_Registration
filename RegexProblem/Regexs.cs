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

        public string ValidateFirstName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string ValidateLastName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string ValidateEmail(string input)
        {
            string pattern = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePhoneNumber(string input)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            return TestPattern(pattern, input);
        }




        public string ValidatePassword(string input)
        {
            string pattern = @"[A-Za-z0-9]{8,16}";

            return TestPattern(pattern, input);

        }



        public string ValidateStringUpperCasePassword(string input)
        {
            string pattern = "[A-Z]{1,}[a-z0-9]";

            return TestPattern(pattern, input);

        }
        public string ValidateNumericPassword(string input)
        {
            string pattern = "[a-zA-Z][0-9]{1,}";
            return TestPattern(pattern, input);

        }
        public string ValidateSpecialCharacter(string input)
        {
            string pattern = "[0-9a-zA-Z][!@#$%&*]{1}";
            return TestPattern(pattern, input);

        }


        public string ValidateCustomPassword(string input)
        {
            string pattern = "([0-9a-zA-Z]{4,4}[!@#$%&*]{1}[0-9a-zA-Z]{3,3})||([0-9a-zA-Z]{3,3}[!@#$%&*]{1}[0-9a-zA-Z]{4,4})||([0-9a-zA-Z]{1,7}[!@#$%&*]{1}[0-9a-zA-Z]{1,7})";
            return TestPattern(pattern, input);
        }




        public string TestPattern(string pattern, string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }


    }
}
