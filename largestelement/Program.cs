using System;
using System.ComponentModel.Design;
using System.Drawing;


class Program
{
     static int sec_largest;
    static int FindLargestElement(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {

            // traverse i+1 to array length
            for (int j = i + 1; j < array.Length; j++)
            {
                // compare array element with
                // all next element

                if (array[i] < array[j])
                {

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        foreach (int k in array)
            if (array[k] < 0)
            {
                Console.WriteLine("none");
            }

        if (array[0] < 0)
        {
            return array[1];
        }
        else 
        {
            return array[0];
        }
        
        
        
    }



    static void Main()
    {
        
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < size; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                array[i] = number;
            }
            else 
            {
                // If input is not a valid integer, assign a default value and proceed
                array[i] = 0;
            }
            
        }
        

        int largest = FindLargestElement(array);
        

        Console.WriteLine("Largest element: " + largest);

        Console.ReadLine();
    }
}
