namespace SORTFIRSTANDSECONDHALF
{
    internal class Program
    {
       static int[] firsthalf(int[] arr)
        {
            
            for(int i=0;i<arr.Length/2;i++)
            {
                for(int j=i+1;j<arr.Length/2;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;  
                    }
                }
            }

            return arr;
            
        } 
        static int[] secondhalf(int[] arr)
        {
            
            for( int i=arr.Length/2;i<arr.Length; i++) {
                for( int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            return arr;


        }
        static void Main(string[] args)
        {
           /* int size = int.Parse(Console.ReadLine()); */
            int[] arr = new int[10];
            for(int i=0;i<arr.Length;i++)
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, out int number))
                {
                    arr[i]=number;
                }
                else
                {
                    arr[i] = 0;
                }
            }
           int[] getfirst =firsthalf(arr); 
            
            int[] getsecond =secondhalf(arr);
            Console.WriteLine("First half array sorted in ascending order are:");
            for(int i=0;i<arr.Length/2;i++)
            {
                Console.WriteLine(getfirst[i]);
            }
            Console.WriteLine("Second half array sorted in descending order are:");
            for (int i = arr.Length /2; i <arr.Length; i++)
            {
                Console.WriteLine(getsecond[i]);
            }

            Console.ReadLine();
        }
    }
}