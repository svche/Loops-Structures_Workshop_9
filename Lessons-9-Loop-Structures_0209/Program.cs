using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_9_Loop_Structures_0209
{
    class Program
    {
        static void Main(string[] args)
        {

// array from random numbers


            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            int minVal = -100;
            int maxVal = 100;
            Random ran = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(minVal, maxVal);
            }

            Console.WriteLine("\nOriginal array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

// min & max

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
// new array with new min & max

            Console.WriteLine("\nMin value: {0}.\tMax value: {1}", min, max);

            Console.WriteLine("\nNew sorted generated array with previous min & max:");
            int[] newArray = new int[size];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ran.Next(min, max);
            }

// sorting

            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length - 1; j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        int temp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = temp;

                    }
                }
            }
            foreach (int a in newArray) Console.Write(a + " ");


// reverse in new array

            Console.WriteLine("\n\nReversed the latest array with making new array: ");
            int[] revNewArray = new int[size];


            for (int i = 0; i < newArray.Length; i++)
            {
                revNewArray[i] = newArray[newArray.Length - i - 1];
            } 

            foreach (int r in revNewArray) Console.Write(r + " ");

// reverse the latest array in existing 

            Console.WriteLine("\n\nReversed the latest array in existing : ");

            Array.Reverse(revNewArray);

            foreach (int r in revNewArray) Console.Write(r + " ");





            Console.ReadLine();
        }
    }
}
