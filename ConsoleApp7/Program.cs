using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер квадратной матрицы: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Введите элемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int positive = 0, negative = 0;
        List<Tuple<int, int>> zeroCoordinates = new List<Tuple<int, int>>();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int value = matrix[i, j];

                if (value > 0) positive++;
                else if (value < 0) negative++;
                else zeroCoordinates.Add(Tuple.Create(i + 1, j + 1));
            }
        }

        Console.WriteLine($"\nРезультаты анализа:");
        Console.WriteLine($"Положительных элементов: {positive}");
        Console.WriteLine($"Отрицательных элементов: {negative}");
        Console.WriteLine("Координаты нулевых элементов:");

        foreach (var coord in zeroCoordinates)
        {
            Console.WriteLine($"({coord.Item1}, {coord.Item2})");
        }
    }
}