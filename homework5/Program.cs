// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// int[] array = new int[4];
// int evenNum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.WriteLine($"{array[i]} ");
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         evenNum ++;
//     }
// }
// Console.WriteLine($"Количество четных чисел в массиве равно {evenNum}.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// int[] array = new int[4];
// int uneven = 0;
// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(-10, 100);
//     Console.WriteLine(array[i]);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 == 1)
//     {
//         uneven = uneven + array[i];
//     }
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {uneven}.] ");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] array = new int[5];
for (int i = 0; i<5; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
}
Array.Sort(array);
int dif = array[4] - array[0];
Console.WriteLine($"Разница между максимальным и минимальным числом равна {dif}.");
