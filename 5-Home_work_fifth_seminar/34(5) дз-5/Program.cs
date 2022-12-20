// Практическое задание №5
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

void RandomDigits(int[] Digits)
{
    for(int i = 0; i < Digits.Length; i++)
    {
        Digits[i] = new Random().Next(100,1000);
    }
}
void CreateArray(int[] Digits)
{
    for(int i = 0; i < Digits.Length; i++)
    {
        Console.Write(Digits[i] + " ");
    }
}
Console.Write("");

int length = 5;
int[] Digits = new int[length];
RandomDigits(Digits);
Console.Write("Имеется массив: ");
CreateArray(Digits);
int count = 0;

for (int i = 0; i < Digits.Length; i++)
{
    if (Digits[i] % 2 == 0)
    count++;
}
Console.WriteLine();

Console.WriteLine($"Количество четных чисел = {count}");