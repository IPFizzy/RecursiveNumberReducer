/*
 * Recursive Number Reducer
 *
 * Demonstrates recursion by repeatedly applying a set of reduction
 * rules until an integer reaches 1. The program also counts and
 * displays every recursive call so the process is easy to follow.
 */

int choice;

Console.WriteLine("Recursive Number Reducer");
Console.WriteLine("------------------------");
Console.Write("Enter an integer: ");

while (!int.TryParse(Console.ReadLine(), out choice) || choice == int.MinValue)
{
    Console.WriteLine("Please enter a valid integer greater than Int32.MinValue.");
    Console.Write("Enter an integer: ");
}

int recursiveCalls = 0;
int result = Utility.ReduceToOne(choice, ref recursiveCalls);

Console.WriteLine();
Console.WriteLine($"Final value: {result}");
Console.WriteLine($"Recursive calls: {recursiveCalls}");

static class Utility
{
    /// <summary>
    /// Recursively reduces an integer to 1 while counting each call.
    /// Every positive-number rule produces a smaller value, which
    /// guarantees progress toward the base case.
    /// </summary>
    internal static int ReduceToOne(int number, ref int callCount)
    {
        callCount++;
        Console.WriteLine($"Call {callCount}: {number}");

        // Base cases.
        if (number == 1)
        {
            return 1;
        }

        if (number == 0)
        {
            Console.WriteLine("  0 is treated as 1.");
            return 1;
        }

        // Normalize negative input before applying the reduction rules.
        if (number < 0)
        {
            Console.WriteLine("  Negative value -> use absolute value");
            return ReduceToOne(Math.Abs(number), ref callCount);
        }

        // Prefer larger divisors so the number shrinks efficiently.
        if (number % 4 == 0)
        {
            Console.WriteLine("  Divisible by 4 -> divide by 4");
            return ReduceToOne(number / 4, ref callCount);
        }

        if (number % 3 == 0)
        {
            Console.WriteLine("  Divisible by 3 -> divide by 3");
            return ReduceToOne(number / 3, ref callCount);
        }

        if (number % 5 == 0)
        {
            Console.WriteLine("  Divisible by 5 -> divide by 5");
            return ReduceToOne(number / 5, ref callCount);
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("  Even -> divide by 2");
            return ReduceToOne(number / 2, ref callCount);
        }

        Console.WriteLine("  Odd -> subtract 1");
        return ReduceToOne(number - 1, ref callCount);
    }
}
