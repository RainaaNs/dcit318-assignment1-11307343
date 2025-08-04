using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TRIANGLE TYPE IDENTIFIER");

        Console.Write("Enter side 1: ");
        bool valid1 = int.TryParse(Console.ReadLine(), out int side1);

        Console.Write("Enter side 2: ");
        bool valid2 = int.TryParse(Console.ReadLine(), out int side2);

        Console.Write("Enter side 3: ");
        bool valid3 = int.TryParse(Console.ReadLine(), out int side3);

        if (valid1 && valid2 && valid3 && side1 > 0 && side2 > 0 && side3 > 0)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Triangle Type: Equilateral");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Triangle Type: Isosceles");
                }
                else
                {
                    Console.WriteLine("Triangle Type: Scalene");
                }
            }
            else
            {
                Console.WriteLine("Invalid triangle: the sum of any two sides must be greater than the third.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
        }
    }
}
