using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < size; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                numbers[i] = number;
            }
            else
            {
                // If input is not a valid integer, assign a default value and proceed
                numbers[i] = 0;
            }
        }

        int max = numbers[0];

        // Loop through the array
        for (int i = 0; i < size; i++)
        {
            // Compare elements of array with max
            if (numbers[i] > max)
                max = numbers[i];
        }

        Console.WriteLine("Largest element present in given array: " + max);
    }
}
