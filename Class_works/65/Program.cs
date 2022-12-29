// Practice #9
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
Console.Clear();
int M = 10;
int N = 15;
Console.WriteLine();
int Line(int m, int n)
{
    if (n<0) return -1;
    if (n==m) return m;
Console.Write(Line(m,n-1) + " ");
return n;
}
Console.WriteLine(Line(M, N));