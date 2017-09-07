using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

// making a matrix from random

            const int size = 5;
            int[,] array = new int[size,size];
            int maxVal = 20;

            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = ran.Next(maxVal);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

// sorting main diagonal   

            int[] tempArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                   if (i == j)
                    {
                        tempArray[i] = array[i, j];
                    }
                }
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length - 1; j++)
                {
                    if (tempArray[j] > tempArray[j+1])
                    {
                        int temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;

                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                         array[i, j] = tempArray[j] ;
                    }
                }
            }

            Console.WriteLine("\nSorted array by main diagonal:\n");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }






            Console.ReadLine();
        }
    }
}
