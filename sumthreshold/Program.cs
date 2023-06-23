using System;
class program
{
    static int CalculateSum(int[] arr, int threshold)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)

        {
            if ((sum + arr[i]) > threshold)
            {
                continue;
                
                
            }
            sum += arr[i];
        }
        return sum;
    }
    
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        
        
        for (int j = 0; j < size; j++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input,out int number))
            {
                arr[j] = number;
            }
            else
            {
                arr[j] = 0;
            }

        }
        int thresh = int.Parse(Console.ReadLine());
        int get = CalculateSum(arr, thresh);
        Console.WriteLine(get);
        Console.ReadLine();

    }
}
