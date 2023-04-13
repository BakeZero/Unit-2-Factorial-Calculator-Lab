using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Factorial Calculator!\n");
        string prompt = "y";
        do
        {
            long factorial = 1;
            Console.Write("Enter an integer (1-20): ");
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 20)
                Console.WriteLine("Invaid Input, please try again.");
            else
            {
                FactorialCalculator(input, ref factorial);
                Console.WriteLine($"The factorial of {input} is {factorial}");
            }

            Console.Write("Continue? (y/n): ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }

    static void FactorialCalculator(int input, ref long factorial)
    {
        if (input == 0)
            return;
        else
        {
            factorial *= input;
            FactorialCalculator(input - 1, ref factorial);
        }
    }
}