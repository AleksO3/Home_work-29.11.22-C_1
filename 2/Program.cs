// Практическое заданме №1
// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
Console.Clear();
Console.WriteLine("Введите 1-е число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    max = number2;
    Console.WriteLine($"Max {max}");
    Console.WriteLine($"Min {number1}");
}
else if (number1 == number2)
{
    Console.WriteLine("ВВЕДЕННЫЕ ЧИСЛА РАВНЫ");
}
    else
    {
    max = number1;
    Console.WriteLine($"Max {max}");
    Console.WriteLine($"Min {number2}");
    }
Console.WriteLine();