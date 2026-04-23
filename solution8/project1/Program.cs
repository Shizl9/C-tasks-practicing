using System;
namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
            static void Calculator()
            {
                Console.Write("Enter first number: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter an operator (+,-,*,/) or type 'exit':");
                string op = Console.ReadLine();

                if (op.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    return; // 👈 ينهي الدالة
                }

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Result: " + (n1 + n2));
                        break;

                    case "-":
                        Console.WriteLine("Result: " + (n1 - n2));
                        break;

                    case "*":
                        Console.WriteLine("Result: " + (n1 * n2));
                        break;

                    case "/":
                        if (n2 != 0)
                            Console.WriteLine("Result: " + (n1 / n2));
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine("\nDo you want another calculation? (yes/no)");
                string again = Console.ReadLine().ToLower();

                if (again == "yes")
                {
                    Calculator(); // 🔁 استدعاء نفسها (Recursion)
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }

            }
    }
}
