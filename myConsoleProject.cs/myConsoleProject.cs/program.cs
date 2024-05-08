using System;


// Define a class named MathOperations
public class MathOperations
{
    // Define a void method named PerformMathOperation that takes two integers as parameters
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer
        int result = firstNumber + 1;

        // Display the second integer to the screen
        Console.WriteLine($"Result of the math operation on {firstNumber}: {result}, Second Number: {secondNumber}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Prompt the user to enter the first integer
        Console.Write("Enter the first integer: ");
        int firstInput = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second integer
        Console.Write("Enter the second integer: ");
        int secondInput = Convert.ToInt32(Console.ReadLine());

        // Call the method in the class, passing in the user-input integers
        mathOps.PerformMathOperation(firstInput, secondInput);
    }
}
