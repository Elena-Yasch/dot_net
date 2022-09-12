// Задача 10: Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Рандомное число: {num}");

// int numX = num /10;
// int num2 = numX % 10;

// Console.WriteLine($"Вторая цифра числа {num} = {num2}.");


// Задача 13: Напиите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// int initNum = new Random().Next(10, 100000);
// Console.WriteLine($"Рандомное число: {initNum}");
// int num = initNum;
// if (num < 100)
// {
//     Console.WriteLine($"Число {num} не содержит три цифры.");
// }
// else
// {
//     while (num > 1000)
//     {
//     num = num /10;
//     }
//     Console.WriteLine($"Третья цифра числа {initNum} = {num % 10}.");

// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// являетяся ли этот день выходным. 

Console.WriteLine("Введите день недели от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine($" Указанныйень под номером - {day} - является выходным.");
}
else
{
    Console.WriteLine($" Указананный день - {day} - не выходной.");
}