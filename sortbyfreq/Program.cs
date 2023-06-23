
using System;
using System.Collections.Generic;
namespace sortbyfreq
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

            List<int> keys = new List<int>(dic.Keys);

            // Custom sorting based on frequency in descending order using for loop
            for (int i = 0; i < keys.Count - 1; i++)
            {
                for (int j = i + 1; j < keys.Count; j++)
                {
                    if (dic[keys[i]] < dic[keys[j]])
                    {
                        int tempKey = keys[i];
                        keys[i] = keys[j];
                        keys[j] = tempKey;
                    }
                }
            }

            foreach (var key in keys)
            {
                Console.WriteLine("Element {0} occurred {1} times", key, dic[key]);
                /* Console.WriteLine("Element {0} occurred {1} times", key.Key, key.Value); */
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[5];
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