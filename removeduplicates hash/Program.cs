namespace removeduplicates
{
    internal class Program
    {
        static HashSet<int> removeduplicate(int[] arr,HashSet<int> hash)
        {
           
           for(int i=0;i<arr.Length;i++)
            {
                hash.Add(arr[i]);   
            }
           return hash;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i=0;i<arr.Length;i++)
            {
                string input = Console.ReadLine();  
                if(int.TryParse(input, out int num))
                {
                    arr[i] = num;
                }
                else
                {
                    arr[i] = 0;
                }
            }
            HashSet<int> hash = new HashSet<int>();
            HashSet<int> ha = removeduplicate(arr,hash);
            Console.Write("Unique Elements: ");
            foreach (int element in hash)
            {
                Console.Write(element + " ");
            }

            Console.ReadLine();
             
        }
    }
}