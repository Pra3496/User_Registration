namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regexs regexs = new Regexs();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\nWell-Come to User Registration Validation Program\n");
                
                Console.WriteLine("1.Validate First name");
                Console.WriteLine("2.Validate Last name");
                Console.WriteLine("3.Validate Email");
                Console.WriteLine("4.Validate Phone Number");
                Console.WriteLine("5.Validate Password");
                Console.WriteLine("6.Validate Atleast One UpperCase");
                Console.WriteLine("7.Validate Atleast One Numeric");
                Console.WriteLine("8.Validate Atleast One Special Charechter");
                Console.WriteLine("\t0 : EXIT");
                Console.Write("\nENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(regexs.ValidateFirstName("kran"));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine(regexs.ValidateLastName("Waghmare"));
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine(regexs.ValidateEmail("abc.xyz@bridgelabz.co.in"));
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine(regexs.ValidatePhoneNumber("91 9638527411"));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(regexs.ValidatePassword("Password"));
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine(regexs.ValidateStringUpperCasePassword("Pranav123"));
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine(regexs.ValidateNumericPassword("Pranav615"));
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.WriteLine(regexs.ValidateSpecialCharacter("Pranav@123"));
                        Console.ReadKey();
                        break;

                    case 0:
                        flag= false;
                        break;
                    default:
                        Console.WriteLine("please enter correct option");
                        break;
                }
            }
        }
    }
}