// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
// Console.WriteLine("Введите любое пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num / 10000;
// int num2 = (num / 1000) % 10;
// int num4 = (num % 100) / 10;
// int num5 = num % 10;

// if (num1 == num5 & num2 == num4)
// {
//     Console.WriteLine($"Число- {num} - является палиндромом.");
// }
// else
// {
//     Console.WriteLine($"Число- {num} - не является палиндромом.");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите три координаты точки А:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите три координаты точки B:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

// Console.WriteLine($"{AB} - расстояние между точками.");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} в кубе равно {Math.Pow(i, 3)}");
}
