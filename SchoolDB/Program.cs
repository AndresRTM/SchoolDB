using Azure.Core;
using SchoolDB.Data;
using SchoolDB.Models;
namespace SchoolDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolDBContext();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("Choose alternativ by enter a number between 1-5");
                Console.WriteLine("1. List all students");
                Console.WriteLine("2. List all students within a class");
                Console.WriteLine("3. Add student");
                Console.WriteLine("4. List staff");
                Console.WriteLine("5. Add staff");

                var input = Console.ReadLine();
                List<Student> students = context.Students.ToList();
                switch (input)
                {

                    case "1":
                        Console.WriteLine("Choose alternativ by enter a number between 1-4");
                        Console.WriteLine("1. List students by firstname and ascending order");
                        Console.WriteLine("2. List students by firstname and descending order");
                        Console.WriteLine("3. List students by lastname and ascending order");
                        Console.WriteLine("4. List students by lastname and descending order");

                        input = Console.ReadLine();
                        if (input.Equals("1"))
                        {
                            var sortedFnameAsc = students.OrderBy(s => s.FirstName);
                            foreach (var s in sortedFnameAsc)
                            {
                                Console.WriteLine($"{s.FirstName} {s.LastName}");
                            }
                        }
                        
                        if (input.Equals("2"))
                        {
                            var sortedFnameDesc = students.OrderByDescending(s => s.FirstName);
                            foreach (var s in sortedFnameDesc)
                            {
                                Console.WriteLine($"{s.FirstName} {s.LastName}");
                            }
                        }

                        if (input.Equals("3"))
                        {


                        }

                        if (input.Equals("4"))
                        {


                        }
                        break;

                    default:
                        break;
                }
            }

        }
    }
}