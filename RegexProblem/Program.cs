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
                Console.WriteLine("2.Validate Email");
                Console.WriteLine("2.Validate Phone Number");
                Console.WriteLine("2.Validate Password");

                Console.WriteLine("\t0 : EXIT");
                Console.Write("\nENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        regexs.ValidateFirstName("Pranav");
                        Console.ReadKey();
                        break;

                    case 2:
                        regexs.ValidateLastName("Waghmare");
                        Console.ReadKey();
                        break;

                    case 3:
                        regexs.ValidateEmail("abc.xyz@bridgelabz.co.in");
                        Console.ReadKey();
                        break;

                    case 4:
                        regexs.ValidatePhoneNumber("91 9638527411");
                        Console.ReadKey();
                        break;

                    case 5:
                        regexs.Validate("Pranav123");
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