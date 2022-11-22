using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode
{
    internal class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int rows = 10;
            int columns = 5;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
