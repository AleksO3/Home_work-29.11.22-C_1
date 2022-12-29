// Home work #9 Recursion
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.Clear();
int ReadInt(string message)                                             // Метод внесения данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)                                                    // Метод (function Аккермана)
{                                                                      // 
  if (m == 0) return n + 1;                                            // 
  else if (n == 0) return A(m - 1, 1);                                 // 
  else return A(m - 1, A(m, n - 1));                                   // 
}

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int funcAkkerman = A(m, n);

Console.Write($"Функция Аккермана = {funcAkkerman}");