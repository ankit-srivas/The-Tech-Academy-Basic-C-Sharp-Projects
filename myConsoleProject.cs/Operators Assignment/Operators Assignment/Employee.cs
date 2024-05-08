using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the Employee class
public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overload the "==" operator to compare Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, null))
        {
            return ReferenceEquals(emp2, null);
        }
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator by simply negating the result of the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override the Equals method for better compatibility with collections and LINQ
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Employee other = (Employee)obj;
        return Id == other.Id;
    }

    // Override the GetHashCode method to ensure consistency with the overridden Equals method
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
