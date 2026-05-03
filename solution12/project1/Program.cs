namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(sum(3, 4));
            Console.WriteLine(sum(3, 4,6));
            Console.WriteLine(sum(3, 5,7));
        }
         static int sum(int a, int b) 
        {
            return a + b;
        }
        static int sum(int a, int b, int c) 
        {
            return a + b + c;
        }
        static int sum(int a , int b , int c, int d)
        { return a+ b+c+d;
        }
    }
}
