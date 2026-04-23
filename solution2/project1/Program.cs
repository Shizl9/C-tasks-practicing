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
            else { Console.WriteLine("Invalid Input!"); }
        }
    }
}
