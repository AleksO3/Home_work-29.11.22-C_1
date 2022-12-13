// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число или около того");
int a = Convert.ToInt32(Console.ReadLine());
string result = (string.Concat($"{a}".Reverse()));
int Result = Int32.Parse(result);
if (a == Result)
{
    Console.WriteLine("Это ПАЛИНДРОМ");
}
else
{
    Console.WriteLine("Число не является палиндромом!");
}