// Practice #9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();

Console.WriteLine("Введите основание и степень");
int osn = Convert.ToInt32(Console.ReadLine());
int step = Convert.ToInt32(Console.ReadLine());
int Stepen(int n, int m)
{
    if (m == 0) return 1;
    n += Stepen(n, m - 1);
    return n;
}
Console.WriteLine(Stepen(osn, step));