using System;

class Package
{
	static void Main()
	{
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

        // Prompt user for package weight
        Console.WriteLine("Please enter the weight of the package : ");
		int pkgweight = Convert.ToInt32(Console.ReadLine());
        // Check if weight exceeds limit
        if (pkgweight > 50) 
		{
			Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.\n");
			return;
			Console.ReadLine();
		}

        // Prompt user for package dimensions
        Console.WriteLine("Please enter the width of the package : ");
		int pkgwidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the height of the package : ");
		int pkgheight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the length of the package : ");
		int pkglength = Convert.ToInt32(Console.ReadLine());

        // Calculate total dimensions
        int dimensiontotal = pkgwidth + pkgheight + pkglength;

        // Check if dimensions total exceeds limit
        if (dimensiontotal > 50) 
		{
			Console.WriteLine("Package too big to be shipped via Package Express.\n");
			return;
			Console.ReadLine();
		}

        // Calculate quote
        int quote = (pkgwidth * pkgheight * pkglength * pkgweight) / 100;

        // Display quote to user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote}.00");
        Console.WriteLine("Thank you!");
    }

}