using System;

// Define an interface called IQuittable
public interface IQuittable
{
    // Define a void method called Quit()
    void Quit();
}

// Define an Employee class that inherits from the IQuittable interface
public class Employee : IQuittable
{
    // Implement the Quit() method defined in the interface
    public void Quit()
    {
        Console.WriteLine("Employee quits the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable employee = new Employee();

        // Call the Quit() method on the object
        employee.Quit();
    }
}
