// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Clear();

// Console.WriteLine("Введите два числа:");
// int numA = Convert.ToInt32(Console.ReadLine());
// int numB = Convert.ToInt32(Console.ReadLine());
// double numX = 0;

// for (int i = 1; i <= numB; i++)
// {
//     numX = Math.Pow(numA, numB);
   
// }

// Console.WriteLine($"'{numA}' в степени '{numB}' = {numX}.");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int numSum = 0;
// int initNum = num;

// while (num > 0)
//     {
//     int lastNum = num % 10;
//     numSum = numSum + lastNum;
//     num = num / 10;
//     }
// Console.WriteLine($"Сумма цифр числа'{initNum}' равна '{numSum}'.");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];

// for (int i = 0; i < array.Length; i ++)
// {
//     array[i] = new Random().Next(1, 100);
//     Console.Write($"{array[i]} ");
// }
