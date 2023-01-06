// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Напишите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int result1 = number % 100;
int result2 = result1 / 10;
Console.WriteLine(result2);