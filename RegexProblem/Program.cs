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
                Console.WriteLine("Well-Come to User Registration Validation Program");
                Console.WriteLine("Enter the option number");
                Console.WriteLine("1.Validate First name");
                Console.WriteLine("1.Validate Last name");

                Console.WriteLine("\t0 : EXIT");
                Console.Write("ENTER YOUR CHOICE : ");
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