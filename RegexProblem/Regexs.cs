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

        
        public void ValidateEmail(string email)
        {
            //abc.xyz@bridgelabz.co.in
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";

            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email id is matching with Regex");
            }
            else
            {
                Console.WriteLine("Email is not matching with Regex");
            }
        }

        public void ValidatePhoneNumber(string phoneNumber)
        {
            //"91 0127131236"
            string phoneNum = @"[0-9]{2}[ ][0-9]{10}";
            if (Regex.IsMatch(phoneNumber, phoneNum))
            {
                Console.WriteLine("Phone Number is matching with regex");
            }
            else
            {
                Console.WriteLine("Phone Number is not matching with Regex ");
            }
        }

        public void ValidatePassword(string pswrd)
        {
            string password = @"[A-Z]{1}[a-z0-9]";
            if (Regex.IsMatch(pswrd, password))
            {
                Console.WriteLine("Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Password is not matching with Regex");
            }
        }


    }
}
