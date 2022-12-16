// Практическое заданме №1
// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine()); // Преобразовываем в целое(int)

while (99 < number && number < 1000)
{
    int Digit = number % 10;
    Console.WriteLine($"Получено число = {number}, последняя цифра числа = {Digit}");
    break;
}
Console.WriteLine();