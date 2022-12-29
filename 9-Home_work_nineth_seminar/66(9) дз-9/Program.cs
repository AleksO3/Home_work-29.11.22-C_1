// Home work #9 Recursion
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int ReadInt(string message)                                             // Метод внесения данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumNat(int M, int N, int sum)                                      // Сумма N чисел между заданными значениями.
{
  sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  SumNat(M, N - 1, sum);
}

int M = ReadInt("Введите M: ");
int N = ReadInt("Введите N: ");
int step = M;

SumNat(M, N, step=0);