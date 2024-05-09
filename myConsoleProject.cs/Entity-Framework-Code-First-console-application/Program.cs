using Entity_Framework_Code_First_console_application;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // Create and add a new student
            var student = new Student { Name = "Ankit Srivastava", Age = 37 };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added to the database.");
        }
    }
}
