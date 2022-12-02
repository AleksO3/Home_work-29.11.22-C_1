/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/Console.Clear();
Console.Write("Введи любое число и подумай, какой у него корень? ");
Console.Write("Итак твое число? ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Какое число являться его корнем? ");
Console.Write("Иии...? ");
int number2 = Convert.ToInt32(Console.ReadLine());
int squareNumber = number2*number2;
if (squareNumber == number1)
Console.Write("Да! Ты прав(а)!!!");
else
Console.Write("Нет(");
