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

            const int size = 5;                                     // making a matrix from random
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

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                }
            }
            Console.WriteLine();
               

            for (int i = 0; i < size; i++)                          // sorting by main diagonal   
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i,i] > array[j, j])
                    {
                        int temp = array[i,i];
                        array[i,i] = array[j,j];
                        array[j,j] = temp;
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
