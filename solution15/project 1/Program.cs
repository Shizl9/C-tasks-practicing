namespace project_1
{
    internal class Program
    {
        class Car
        {
            public string color;
            public int model_year;
          
            private int temp=10;
                public int Speed
            {
                get { return temp; }
                set
                {
                    if (value > 0)
                        temp = value;
                }
            }


        }
        static void Main(string[] args)
        {
            Car my_car = new Car();
            Console.WriteLine("please Enter speed of car:");
            my_car.Speed= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(my_car.Speed);
        }
    }
}
