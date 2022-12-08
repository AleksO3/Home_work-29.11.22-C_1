// Практическое заданме №2
// Задача 12(2): Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Clear();
Console.WriteLine("Введите 1-е число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 % N2 == 0)
{
    Console.WriteLine("1-е Число кратно 2-му числу");
}
else
{
    int remainder = N1 % N2;
    Console.WriteLine($"Остаток от деления 1-го числа на 2-е = {remainder}");
}