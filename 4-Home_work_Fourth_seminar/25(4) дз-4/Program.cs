// Правктическое задание №4
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!
Console.Clear();
int GetNumber(string message)                             // метод для вывода на экран и ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N1 = GetNumber("Введите первое число: ");             // Используем созданный метод, внося только одну строку
int N2 = GetNumber("Введите второе число: ");

int rez = 1;
for (int i = 1; i <= N2; i++)
{
    rez = rez * N1;
}
if (N1 == 0 && N2 == 0)
{
    Console.WriteLine("Данное выражение не имеет смысла");
}
else
{
    Console.WriteLine($"{N1} в {N2}-й степени");
    Console.Write($"равняется {rez}");
}