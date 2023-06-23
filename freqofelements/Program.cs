  using System;
    using System.Collections.Generic;
namespace freqofelements
{
    internal class Program
    {
        static void Findfreq(Dictionary<int, int> dic, int[] arr)
        {
            foreach (int element in arr)
            {
                if (dic.ContainsKey(element))
                {
                    dic[element]++;
                }
                else
                {
                    dic[element] = 1;
                }
            }

             

            foreach (var key in dic)
            {
                
                 Console.WriteLine("Element {0} occurred {1} times", key.Key, key.Value); 
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    array[i] = number;
                }
                else
                {
                    array[i] = 0;
                }
            }

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            Findfreq(frequencyMap, array);
            Console.ReadLine();
        }
    }
}