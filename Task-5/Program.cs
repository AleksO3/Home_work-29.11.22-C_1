/* Практическое заданме №1
Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/
Console.Clear();
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;

while (-N <= n)
{
    Console.Write($" {-n} ");
    n--;
}

// while (n < N)
// {
//     Console.Write($" {n}");
//     n++;
// }

// for (int i = 1; -N < i && i < N; i--, i--)
// {
//     Console.Write($"{i},  ");
// }
// Console.WriteLine();