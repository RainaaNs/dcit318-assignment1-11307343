using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TICKET PRICE CALCULATOR");

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Invalid age. Please enter a valid number between 0 and 120.");
                return;
            }

            int price = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"Ticket Price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
