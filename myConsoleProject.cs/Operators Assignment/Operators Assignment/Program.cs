using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects
        Employee emp1 = new Employee(1, "John", "Doe");
        Employee emp2 = new Employee(2, "Jane", "Smith");

        // Compare the two Employee objects using the overloaded "==" operator
        if (emp1 == emp2)
        {
            Console.WriteLine("The two employees have the same Id.");
        }
        else
        {
            Console.WriteLine("The two employees have different Ids.");
        }
    }
}
