// Практическое заданме №2
//Задача 16(2): Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Clear();
Console.WriteLine("Введите 1-е число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число ");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1*n1==n2 || n2*n2==n1)
{
    Console.WriteLine($"Да, одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Нет, ни одно из чисел не является квадратом другого числа");
}