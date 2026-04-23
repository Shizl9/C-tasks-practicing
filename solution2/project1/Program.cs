namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
Console.WriteLine("please Enter numper:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
            { Console.WriteLine("positive"); }
            else if (num < 0)
            { Console.WriteLine("nigative"); }
            else if (num == 0)
            { Console.WriteLine("zero"); }
            else { Console.WriteLine("Invalid Input!");
            }

          
            //*******Task2*********
            Console.WriteLine("Enter number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            { Console.WriteLine("number is Even"); }
            else
            { Console.WriteLine("number is Odd"); }


            //*******Task3*********
            Console.WriteLine("Enter Student Socre from 0-100:");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Very good");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Good");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }



            //***************Task4**************
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter paasword:");
            string password = Console.ReadLine();
            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalide username or password!");
            }

        }
    }
}
