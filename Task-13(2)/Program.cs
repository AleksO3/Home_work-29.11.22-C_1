// Практическое заданме №2
//Задача 13(2): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//до 8 знаков через ЦИКЛ
Console.Clear();
Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());// Преобразовываем в целое(int) и помещаем в переменную

while (99 < number && number < 100000000)
{
    int Digit = number % 10;
    Console.WriteLine($"Получено число = {number}, третья цифра заданного числа = {Digit}");
    break;
}

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}

Console.WriteLine();