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

int A = GiveMeCount("Введите число: ");

int sum = 0;
for (int i = 0; i <= A; i++)
{
    int digit = A % 10;
    sum = sum + digit;
}

Console.WriteLine(sum);