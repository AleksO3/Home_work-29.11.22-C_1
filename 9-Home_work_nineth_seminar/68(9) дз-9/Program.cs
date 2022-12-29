// Home work #9 Recursion
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// функция ack(n, m)
// если n = 0
// вернуть m + 1
// иначе, если m = 0
// вернуть ack (n - 1, 1)
// еще
// вернуть ack(n - 1, ack (n, m - 1))

// Следующая частично итерационная реализация несколько более эффективна:

// функция ack(n, m)
// пока n ≠ 0
// если m = 0
// m:= 1
// иначе
// m:= ack(n, m - 1)
// n:= n - 1
// вернуть m + 1

// Ещё более эффективные реализации используют динамическое программирование.
// Grossman & Zeitman опубликовали алгоритм вычисления функции Аккермана без
// использования кэша, занимающий время O ( n A ( n , m ) ) {\displaystyle {\mathcal {O}}(nA(n,m))}
// и использующий O ( n ) {\displaystyle {\mathcal {O}}(n)} памяти[3].
// В функциональном языке программирования Haskell, реализация напрямую отражает определение:

// ack 0 n = n+1
// ack n 0 = ack (n-1) 1
// ack n m = ack (n-1) (ack n (m-1))
Console.Clear();
int ReadInt(string message)                     // Метод внесения данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ack(int m, int n)                           // Метод (function Аккермана).
{                                               // https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int funcAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {funcAkkerman}");