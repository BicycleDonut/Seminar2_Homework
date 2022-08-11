// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:   ");
int N = Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);
if (N >= 100)
{
    string s = N.ToString();
    int third = int.Parse(s[2].ToString());
    Console.WriteLine($"Третья цифра числа: {third}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}





