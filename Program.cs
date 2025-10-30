namespace studentmanagementsystem
{
    class Student
    {
        public int Id;
        public string Name;
        public double Marks;

        public Student(int id, string name, double marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Marks: {Marks}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int choice;

            do
            {
                Console.WriteLine("\n=== Student Management System ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Remove Student by ID");
                Console.WriteLine("5. Display Topper of Class");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Marks: ");
                        double marks = Convert.ToDouble(Console.ReadLine());
                        students.Add(new Student(id, name, marks));
                        Console.WriteLine("Student Added Successfully!");
                        break;

                    case 2:
                        if (students.Count == 0)
                            Console.WriteLine("No students found!");
                        else
                        {
                            Console.WriteLine("\nList of Students:");
                            foreach (var s in students)
                                s.Display();
                        }
                        break;

                    case 3:
                        Console.Write("Enter Student ID to Search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Student found = null;

                        // Simple linear search
                        foreach (var s in students)
                        {
                            if (s.Id == searchId)
                            {
                                found = s;
                                break;
                            }
                        }

                        if (found != null)
                            found.Display();
                        else
                            Console.WriteLine("Student not found!");
                        break;

                    case 4:
                        Console.Write("Enter Student ID to Remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Student toRemove = null;

                        // Simple check to remove
                        foreach (var s in students)
                        {
                            if (s.Id == removeId)
                            {
                                toRemove = s;
                                break;
                            }
                        }

                        if (toRemove != null)
                        {
                            students.Remove(toRemove);
                            Console.WriteLine("Student removed successfully!");
                        }
                        else
                            Console.WriteLine("Student not found!");
                        break;

                    case 5:
                        if (students.Count == 0)
                            Console.WriteLine("No students to evaluate!");
                        else
                        {
                            // Simple way to find topper
                            Student topper = students[0];
                            foreach (var s in students)
                            {
                                if (s.Marks > topper.Marks)
                                    topper = s;
                            }
                            Console.WriteLine("\nTopper of the Class:");
                            topper.Display();
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }

            } while (choice != 6);
        }
    }
}
