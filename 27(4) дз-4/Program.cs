// Практическое задание №4
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int GiveMeCount(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GiveMeCount("Введите число: ");
int enterN = Convert.ToString(N).Length;
int progress = 0;
int rez = 0;

for (int i = 0; i < enterN; i++)
{
    progress = N - N % 10;
    rez = rez + (N - progress);
    N = N / 10;
}

int SumNumbers = rez;
Console.WriteLine("Сумма цифр в числе: " + SumNumbers);
