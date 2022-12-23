// Практическое задание №6
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();
// Решение через рекурсию.

int number = 22;
PrintBinarView(number);

void PrintBinarView(int n)
{
    if (n <= 0) return;
    PrintBinarView(n / 2);
    Console.Write(n % 2);
}