/*
 * Keon Bushman
 * CST - 250
 * 06/07/2026
 * Count To One Recursion
 * Activity 3
 * Activity 3 Guide
 */

//---------------------------------------------------------------
// Start of the Main Method
//---------------------------------------------------------------

// Declare and initialize
int choice = 0, result = 0, counter = 0;
string input = "";

// Prompt the user for a number
Console.Write("Enter a number: ");

// Get the users input
input = Console.ReadLine();

// See if the user entered valid input
while (!int.TryParse(input, out choice))
{
    Console.WriteLine("Invalid number");

    // Re-Prompt the user for a number
    Console.Write("Enter a number: ");

    // Get the users input
    input = Console.ReadLine();
}

// Call the CountToOne function
result = Utility.CountToOne(choice, ref counter);

Console.WriteLine($"The end number is {result}");
Console.WriteLine($"The number of recursive calls is {counter}");

//---------------------------------------------------------------
// End of the Main Method
//---------------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Count to one using recursion
    /// </summary>
    /// <param name="num"></param>
    /// <param name="counter"></param>
    /// <returns></returns>
    internal static int CountToOne(int num, ref int counter)
    {
        // Print out the current number
        Console.WriteLine($"The current number is {num}");

        // Count the current recursive call
        counter++;

        // Check if the number is 0
        if (num == 0)
        {
            Console.WriteLine("The number is 0. Change the number to 1");

            return 1;
        }

        // Check if the number is negative
        if (num < 0)
        {
            Console.WriteLine("The number is negative. Change the number to positive");

            return CountToOne(Math.Abs(num), ref counter);
        }

        // Check if the number is 1
        if (num == 1)
        {
            return 1;
        }
        else
        {
            // Check if the number is divisible by 4
            if ((num % 4) == 0)
            {
                Console.WriteLine("The number is divisible by 4. Divide by 4");

                // Divide the number by 4 and call the method
                return CountToOne(num / 4, ref counter);
            }
            else if ((num % 3) == 0)
            {
                Console.WriteLine("The number is divisible by 3. Divide by 3");

                // Divide the number by 3 and call the method
                return CountToOne(num / 3, ref counter);
            }
            else if (((num % 5) == 0) && (num < 50) && (num > 5) && ((num % 2) != 0))
            {
                Console.WriteLine("The number is divisible by 5. Multiply by 2");

                // Multiply the number by 2 and call the method
                return CountToOne(num * 2, ref counter);
            }
            else if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even. Divide by 2");

                // Divide the number by 2 and call the method
                return CountToOne(num / 2, ref counter);
            }
            else
            {
                Console.WriteLine("The number is odd. Subtract 1");

                // Subtract 1 and call the method
                return CountToOne(num - 1, ref counter);
            }
        }
    }
}
