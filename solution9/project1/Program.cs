namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
            Console.WriteLine("Hello, World!");
        }
        static void Calculator()
        {
            Console.WriteLine("Try programiz.pro");
            Console.WriteLine("=========================");
            Console.WriteLine("Hello from Calculator App");
            Console.WriteLine("=========================");

            Console.WriteLine("Please enter first number:");
            int Fnum;
            int Snum;

            while (true)
            {
                try
                {
                    Fnum = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid Number! please Enter a number:");
                }
            }

            Console.WriteLine("Please enter second number:");

            while (true)
            {
                try
                {
                    Snum = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid Number! please Enter a number:");
                }
            }

            Console.WriteLine("Enter operation (+, -, *, /):");
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
                Console.WriteLine($"{Fnum}+{Snum}={Fnum + Snum}");

            else if (op == '-')
                Console.WriteLine($"{Fnum}-{Snum}={Fnum - Snum}");

            else if (op == '*')
                Console.WriteLine($"{Fnum}*{Snum}={Fnum * Snum}");

            else if (op == '/')
                Console.WriteLine($"{Fnum}/{Snum}={Fnum / Snum}");

            else
                Console.WriteLine("Invalid operation!");

            Console.WriteLine("\nDo you want another calculation? (y/n)");
            string again = Console.ReadLine().ToLower();

            if (again == "y")
            {
                Calculator();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
