/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/Console.Clear();
Console.Write("Введите 1-е число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int NumberTwo2 = number2 * number2;
if (number1 == NumberTwo2)
Console.WriteLine("да");
else
Console.WriteLine("Нет");