// Home work #9 Recursion
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
int ReadInt(string message)                                             // Метод внесения данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DigitGet(int N, int digit)                                         // Метод выдачи чисел по убыванию до N.
{
    if (digit > N)
    {
        return;
    }
    else
    {
        DigitGet(N, digit + 1);
        Console.Write(digit + ", ");
    }
}

int N = ReadInt("Укажите число до которого вывести числа: ");
int digit = 2;                                                         // Чтобы последняя цифра не шла с запятой, укажем digit == 2,
DigitGet(N, digit);
Console.Write("1.");                                                   // И в конце добавим цифру с точкой.
