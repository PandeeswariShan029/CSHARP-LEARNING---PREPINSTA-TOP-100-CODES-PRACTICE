using System;
class program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                arr[i] = number;
            }
            else
            {
                arr[i] = 0;
            }

        }
        for (int j = 0; j < n; j++)
        {

            if (arr[j] >= 0)
            {
                sum += arr[j];
            }
        }

            Console.WriteLine(sum);


        }
    }
