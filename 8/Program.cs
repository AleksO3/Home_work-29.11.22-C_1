// Практическое задание №1
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите  +[положительное]+  число, до которого желаете увидеть весь список четных чисел");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ниже представленны все чётные числа от 1 до {N}");
for (int i = 2; i <= N; i=i+2)
{
    Console.Write($"{i} - ");
}
Console.WriteLine();Console.WriteLine();Console.WriteLine();
Console.WriteLine("!!!~-=С наступающим!=-~!!!");
