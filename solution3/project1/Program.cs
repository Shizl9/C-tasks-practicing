namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 – Day Name Printer
            Console.WriteLine("Enter number from(1-7):");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuseday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;

            }



            //Task 2 – Multiplication Tabl

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));

            }


            //Task 3 – Countdown Timer:
            Console.Write("Enter a positive number : ");
            int count = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else
            {
                while (number >= 1)
                {
                    Console.WriteLine(number);
                    number--;
                }

                Console.WriteLine("Go!");
            }



            //Task 4 – Season Detector with Month Validation
            Console.WriteLine("Enter a month number (1-12):");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }


            //Task 5 – Sum of Even and Odd Numbers

            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine("sum of even number=" + evenSum);
            Console.WriteLine("sum of odd number=" + oddSum);



            //Task 6 – Password Retry System
            Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();
            int attempts = 3;
            while (attempts > 0)
            {
                if (password == "1234")
                {
                    Console.WriteLine("Access granted");
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine("Wrong password");
                    if (attempts > 0)
                    {
                        Console.WriteLine(" Attempts left: " + attempts);
                        password = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Account Locked");
                    }
                }

            }




            //Task 7 – Simple Calculato
            Console.Write("Enter first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter an operator (+,-,*,/) or type 'exit':");
                string op = Console.ReadLine();
                if (op == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
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
                        {
                            Console.WriteLine("Result: " + (n1 / n2));
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }


            //Task 8 – Prime Number Checker in a Range
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());

            bool foundPrime = false;

            for (int i = start; i <= end; i++)
            {
                if (i > 1)
                {
                    bool isPrime = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(i);
                        foundPrime = true;
                    }
                }
            }

            if (!foundPrime)
            {
                Console.WriteLine("No prime numbers found");
            }

            //Task 9 – Student Grade Report
            Console.Write("Enter number of students: ");
            int numberofstudents = int.Parse(Console.ReadLine());
            int excellent = 0;
            int verygood = 0;
            int good = 0;
            int pass = 0;
            int fail = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            for (int i = 1; i <= numberofstudents; i++)
            {
                Console.Write("Enter score for student " + i + ": ");
                int score = int.Parse(Console.ReadLine());
                if (score > highest) highest = score;
                if (score < lowest) lowest = score;

                int gradeKey = score / 10;
                switch (gradeKey)
                {
                    case 10:
                    case 9:
                        excellent++;
                        break;
                    case 8:
                        verygood++;
                        break;
                    case 7:
                        good++;
                        break;
                    case 6:
                        pass++;
                        break;
                    default:
                        fail++;
                        break;
                }
                Console.WriteLine("\n--- Grade Report ---");
                Console.WriteLine("Excellent: " + excellent);
                Console.WriteLine("Very Good: " + verygood);
                Console.WriteLine("Good: " + good);
                Console.WriteLine("Pass: " + pass);
                Console.WriteLine("Fail: " + fail);

                Console.WriteLine("Highest Score: " + highest);
                Console.WriteLine("Lowest Score: " + lowest);
            }

         

        

    }

    }

}
