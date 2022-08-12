// Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

string N = new Random().Next(100, 1000).ToString();
Console.WriteLine($"Число: {N}");
int second = int.Parse(N[N.Length - 2].ToString());
Console.WriteLine($"Вторая цифра числа: {second}");

