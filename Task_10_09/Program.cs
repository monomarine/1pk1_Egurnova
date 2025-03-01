using System;
using System.Runtime.InteropServices;

namespace Task_10_09
{
    internal class Program
    {
        /*генерация двумерного массива
         вывод на консоль с подсветкой отрицательных значений*/
        static void Main(string[] args)
        {
            int[,] numbers = GenerateTwoDimensionArray(10, 10);
            PrintArrayWithColor(numbers, ConsoleColor.Yellow, ConsoleColor.DarkRed);
        }
        /// <summary>
        /// генерация двумерного целочисленного массива со значениями от -99 до 99
        /// </summary>
        /// <param name="rows">количество строк</param>
        /// <param name="columns">количество столбцов</param>
        /// <returns>сгенерированный массив</returns>
        static int[,] GenerateTwoDimensionArray(int rows, int columns)
        {
            Random random = new Random();
            int[,] resultArray = new int[rows, columns];

            for(int i = 0; i< rows; i++)
            {
                for( int j = 0; j< columns; j++)
                {
                    resultArray[i, j] = random.Next(-99, 100);
                }
            }

            return resultArray;
        }
        /// <summary>
        /// вывод двумерного массива с подсветкой отрицательных значений
        /// </summary>
        /// <param name="array">вх массив</param>
        /// <param name="foregroundColor">цвет текста</param>
        /// <param name="backgroundColor">цвет фона</param>
        static void PrintArrayWithColor(int[,] array, ConsoleColor foregroundColor, ConsoleColor backgroundColor) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] < 0)
                    {
                        Console.BackgroundColor = backgroundColor;
                        Console.ForegroundColor = foregroundColor;
                        Console.Write(array[i, j]+"\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(array[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
