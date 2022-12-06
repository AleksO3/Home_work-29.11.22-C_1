// Практическое заданме №1
// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int N3 = Convert.ToInt32(Console.ReadLine());
int MAX = N1;
if (N2 > N1 && N2 > N3)
{
    MAX = N2;
}
if (N3 > N2 && N3 > N1)
{
    MAX = N3;
}
else
{
    MAX = N1;
}
Console.WriteLine($"Max = {MAX}");
Console.WriteLine();