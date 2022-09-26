// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.WriteLine("Введите размер массива(кол-во строк и стобцов)");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
float[,] arr = new float[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(-10, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int[,] newArr = new int[3, 4] {{1, 4, 7, 2},
//                                {5, 9, 2, 3},
//                                {8, 4, 2, 4}};
// Console.WriteLine("Введите индекс строки и столбца:");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = Convert.ToInt32(Console.ReadLine());    

// if (i <= newArr.GetLength(0) && j <= newArr.GetLength(1))
// {
//     Console.WriteLine($"Это число - {newArr[i,j]}");
// }
// else
// {
//     Console.WriteLine($"Такого числа нет в массиве!");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] newArr = new int[3, 4] {{1, 4, 7, 2},
//                                {5, 9, 2, 3},
//                                {8, 4, 2, 4}};
// double sum = 0;
// double res = 0;
// for (int i = 0; i < newArr.GetLength(0); i++)
// {
//     for (int j = 0; j < newArr.GetLength(1); j++)
//     {
//         Console.Write($"{newArr[i, j]} ");
  
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < newArr.GetLength(1); j++)
// {
//     for (int i = 0; i < newArr.GetLength(0); i++)
//     {
//         sum += newArr[i, j];
//         res = sum / newArr.GetLength(0);       
//     }
//     Console.WriteLine($"Среднее арифметическое {j+1} столбца:{res}");
// }
