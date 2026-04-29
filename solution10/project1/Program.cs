namespace project1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Stack
            Stack<string> names = new Stack<string>();// Create a stack of strings named: names
            //اضافة بيانات جاهزة :
            names.Push("Yahya");
            names.Push("Ahmed");
            names.Push("Ali");
            names.Push("Omar");
            //
            #endregion
            #region queue
            Queue<string> names = new Queue<string>();

            names.Enqueue("Yahya");
            names.Enqueue("Ahmed");
            names.Enqueue("Ali");
            names.Enqueue("Omar");

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Add String");
                Console.WriteLine("2. Print First Element");
                Console.WriteLine("3. Delete First Element");
                Console.WriteLine("4. Show All Elements");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter string: ");
                    string input = Console.ReadLine();
                    names.Enqueue(input);
                }
                else if (choice == 2)
                {
                    if (names.Count > 0)
                        Console.WriteLine("First element: " + names.Peek());
                    else
                        Console.WriteLine("Queue is empty");
                }
                else if (choice == 3)
                {
                    if (names.Count > 0)
                        Console.WriteLine("Deleted: " + names.Dequeue());
                    else
                        Console.WriteLine("Queue is empty");
                }
                else if (choice == 4)
                {
                    if (names.Count > 0)
                    {
                        Console.WriteLine("All elements:");
                        foreach (var name in names)
                            Console.WriteLine(name);
                    }
                    else
                        Console.WriteLine("Queue is empty");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            #endregion
            #region dictionary
            Dictionary<string, int> student = new Dictionary<string, int>();

            // إضافة طالب
            student.Add("Ali", 25);

            // طباعة
            Console.WriteLine($"Ali is {student["Ali"]} years old");

            try
            {
                // تعديل قيمة Ali
                student["Ali"] = 33;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                // حذف Ali
                student.Remove("Ali");

                // التحقق هل يوجد قيمة 33
                Console.WriteLine(student.ContainsValue(33));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

        }
    }
}