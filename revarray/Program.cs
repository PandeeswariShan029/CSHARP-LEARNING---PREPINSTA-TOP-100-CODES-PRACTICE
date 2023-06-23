using System;
class program
{
    static int[] revArray(int[] arr)
    {
        

        for (int i = arr.Length - 1; i >= 0; i--)
        {

            Console.WriteLine(arr[i]);



        }

        return arr;



    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];


        for (int j = 0; j < size; j++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                arr[j] = number;
            }
            else
            {
                arr[j] = 0;
            }

        }

        int[] get = revArray(arr);
      
        Console.ReadLine();

    }
}
