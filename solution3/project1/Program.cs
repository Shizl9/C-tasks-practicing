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

        }
    }
}
