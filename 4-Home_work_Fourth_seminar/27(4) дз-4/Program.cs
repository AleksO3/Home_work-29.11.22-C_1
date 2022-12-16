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
int enterN = Convert.ToString(N).Length;                        // Преобразовали к длине string
int progress = 0;
int rez = 0;

for (int i = 0; i < enterN; i++)                                // указали условие < длины числа(строки)
{
    progress = N - N % 10;                                      // каждую итерацию откидываем число
    rez = rez + (N - progress);
    N = N / 10;
}

int SumNumbers = Math.Abs(rez);                                 // Для преобразования отрицательных чисел в положительные
Console.WriteLine($"Сумма цифр в данном числе = {SumNumbers}");
