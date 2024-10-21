using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            // Convert the input strings to integers
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            // Perform the division
            int result = Divide(num1, num2);

            // If no exceptions, print the result
            Console.WriteLine($"The result of dividing {num1} by {num2} is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both inputs were not valid numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: One or both numbers are too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    // Division method
    static int Divide(int a, int b)
    {
        return a / b;
    }
}
