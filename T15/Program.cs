// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7:   ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 1)
{
    Console.WriteLine("Понедельник.Рабочий день.");
}
else if (N == 2)
{
    Console.WriteLine("Вторник.Рабочий день.");
}
else if (N == 3)
{
    Console.WriteLine("Среда.Рабочий день.");
}
else if (N == 4)
{
    Console.WriteLine("Четверг.Рабочий день.");
}
else if (N == 5)
{
    Console.WriteLine("Пятница.Рабочий день.");
}
else if (N == 6)
{
    Console.WriteLine("Cуббота.Выходной.");
}
else if (N == 7)
{
    Console.WriteLine("Cуббота.Выходной.");
}