using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reni
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[7] { 1, 2, 6, 7, 19, 20, 6 };
            int[] arr2 = new int[11] { 1, 22, 3, 4, 5, 6, 7, 19, 21, 22, 7 };
            int equalNumbers = 0;
            int equalIndex = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i]) equalIndex += 1;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j]) equalNumbers += 1;
                }
            }

            Console.WriteLine(equalIndex);
            Console.WriteLine(equalNumbers);
        }
    }
}
