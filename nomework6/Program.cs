// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Clear();
// Console.WriteLine("Введите с консоли сколько чисел будет в вашем списке:");
// int mNum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = new int [mNum];
// int resNum = 0;

// for (int i = 0; i < newArray.Length; i++)
// {
//     Console.WriteLine($"Введите с консоли число под индексом {i}:");
//     newArray[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 0; i < mNum; i++)
// {
//     if (newArray[i] > 0)
//     {
//         resNum ++;
//     }
// } 
// Console.WriteLine($"В списке больше нуля - {resNum} числа/чисел.");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).

Console.WriteLine("Введите первую точку первой прямой:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую точку первой прямой:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую точку второй прямой:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую точку второй прямой:");
int k2 = Convert.ToInt32(Console.ReadLine());

int y1 = k1 * x + b1;
int y2 = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых равна: {y1}; {y2}.");
