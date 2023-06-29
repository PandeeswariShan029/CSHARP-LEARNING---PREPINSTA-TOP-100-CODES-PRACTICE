namespace longest_plaindrome
{
    
    internal class Program
    {
        static bool Ispalindrome(int n)
        {
            int originalnum = n;
            
            int rev = 0;
            while (n > 0)
            {
               int  rem = n % 10;
                rev = (rev * 10) + rem;
                n /= 10;

            }
            return rev== originalnum;


        }
        static int longestpalindrome(int[] arr)
        {
            int lp = 0;
            foreach (int element in arr)
            {
                if ((Ispalindrome(element) && element > lp))
                {
                    lp = element;
                }
            }
            return lp;
        }
        
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    arr[i] = num;
                }
                else
                {
                    arr[i] = 0;
                }
            }
            int get = longestpalindrome(arr);
            Console.WriteLine("longest palindrome in the array is "+get);
            
            
               
            
            Console.ReadLine();

        }
    }
}