/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[7, 7]
        {
            {1, -3, 5, 7, -9, 11, 13},
            {3, 6, -2, -4, 6, -8, 5},
            {7, -10, 12, -14, 16, 18, -20},
            {2, -5, 8, -11, 14, -17, 20},
            {3, 6, 9, 12, 15, 18, 21},
            {4, -7, 10, 13, -16, 19, 22},
            {5, 10, 15, 20, 25, 30, 35}
        };

        int sum = 0;

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (array[i, j] < 0 && array[i, j] % 2 != 0)
                {
                    sum += Math.Abs(array[i, j]);
                }
            }
        }

        Console.WriteLine("Сумма модулей отрицательных нечетных элементов: " + sum);
    }
}
