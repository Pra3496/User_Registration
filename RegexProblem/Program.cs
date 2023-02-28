namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Well-Come to User Registration Validation Program");
                Console.WriteLine("Enter the option number");
                Console.WriteLine("1.Validate first name");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Regexs regexs = new Regexs();
                        regexs.ValidateFirstName("Pranav");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("please enter correct option");
                        break;
                }
            }
        }
    }
}