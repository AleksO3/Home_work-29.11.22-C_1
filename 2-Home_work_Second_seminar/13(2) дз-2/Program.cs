// Практическое заданме №2
//Задача 13(2): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// до 8 знаков через ЦИКЛ 

Console.Clear();
Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());          // Преобразовываем в целое(int) и помещаем в переменную

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    for (; 1000 < number && number <= 100000000; number = number / 10) ;
    {
        int dig = number % 10;
        Console.WriteLine($"третья цифра заданного числа = {dig}");
    }
}