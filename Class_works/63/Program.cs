// Practice #9
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int NaturalLine(int n)
{
    if (n < 0) return -1;
    if (n==1) return 1;
    Console.Write(NaturalLine(n - 1) + " ");
    return n;
}
Console.WriteLine($"{NaturalLine(number)}");
Console.WriteLine($"\nлинейка чисел от 1 до {number}");