using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Program3
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        public void arrayRev(int[] arr, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }

        }
        public void reverse()
        {
            Console.Write("Original Array Elements :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            arrayRev(arr, 0, (arr.Length - 1));
            Console.Write("\nReversed Array Elements :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
 
}
