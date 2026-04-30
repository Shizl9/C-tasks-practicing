namespace project1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Stack
            Stack<string> names1 = new Stack<string>();// Create a stack of strings named: names
            //اضافة بيانات جاهزة :
            names1.Push("Yahya");
            names1.Push("Ahmed");
            names1.Push("Ali");
            names1.Push("Omar");
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
            #region Data Structures task (stack,Queue,Dictionary):
            // Student Registration 
            Dictionary<int, string> StudentsData = new Dictionary<int, string>();
            StudentsData.Add(1, "Mohammed");
            StudentsData.Add(2, "Ali");
            StudentsData.Add(3, "Sara");
            StudentsData.Add(4, "Merna");

            //store student Id with queue
            Queue<int> StudentIds = new Queue<int>();

            //servese student registration with stack
            Stack<int> StudentRegservedStack = new Stack<int>();

            while (true) // عرض القائمة كل مرة
            {
                Console.WriteLine("\n=========Menue========");
                Console.WriteLine("1.  Add a new student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Show All Students");
                Console.WriteLine("5. Join Service Queue");
                Console.WriteLine("6. Serve Next Student");
                Console.WriteLine("7. Undo Last Service");
                Console.WriteLine("8. Show Queue");
                Console.WriteLine("9. Exit");

                Console.Write("Enter choice: ");
                int choose;

                try
                {
                    choose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int id;
                string name;

                switch (choose)
                {
                    //Add Student
                    case 1:
                        Console.Write("Enter student ID: ");// إدخال رقم الطالب
                        id = int.Parse(Console.ReadLine()); 
                        Console.Write("Enter Name: ");
                         name = Console.ReadLine(); // إدخال اسم الطالب
                        if (!StudentsData.ContainsKey(id))
                        {
                            //  إذا غير موجود → نضيف
                            StudentsData.Add(id, name);
                            Console.WriteLine("Student Added");
                            
                        }
                        else
                        {
                           
                            Console.WriteLine("ID already exists");
                        }
                        break;

                    case 2:// Update Student
                        try
                        {
                            Console.Write("Enter student ID: ");
                            id = int.Parse(Console.ReadLine());

                            if (StudentsData.ContainsKey(id))
                            {
                                Console.Write("Enter new name: ");
                                StudentsData[id] = Console.ReadLine();
                                Console.WriteLine("Updated");
                            }
                            else
                            {
                                Console.WriteLine("Student not found");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;


                    case 3:// Remove Student
                        Console.Write("Enter student ID: ");

                        try
                        {
                            id = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }

                        if (StudentsData.ContainsKey(id))// إذا موجود → نحذف
                        {
                            StudentsData.Remove(id);
                            Console.WriteLine("Student Removed");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");// إذا غير موجود → نطبع رسالة
                        }
                        break;

                    case 4:// Show All Students
                        Console.WriteLine("All Students:");
                        foreach (var s in StudentsData)
                        {
                            Console.WriteLine(s.Key + " : " + s.Value);
                        }
                        break;

                    case 5:// Join Service Queue
                        Console.Write("Enter student ID: ");

                        try
                        {
                            id = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }

                        if (StudentsData.ContainsKey(id))
                        {
                            StudentIds.Enqueue(id);
                            Console.WriteLine("Added to queue");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        break;

                    case 6:// Serve Next Student
                        if (StudentIds.Count > 0)
                        {
                            int served = StudentIds.Dequeue();
                            StudentRegservedStack.Push(served);

                            Console.WriteLine("Served: " + StudentsData[served]);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;


                    case 7:// Undo Last Service
                        if (StudentRegservedStack.Count > 0)
                        {
                            int last = StudentRegservedStack.Pop();
                            StudentIds.Enqueue(last);

                            Console.WriteLine("Undo: " + StudentsData[last]);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to undo");
                        }
                        break;
                    // Show Queue
                    case 8:
                        Console.WriteLine("Queue:");

                        if (StudentIds.Count > 0)
                        {
                            foreach (var q in StudentIds)
                            {
                                Console.WriteLine(StudentsData[q]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;

                    case 9:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;



                }
            }
            #endregion
            ...
        }
    }
}