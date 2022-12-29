// Practice #9
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.WriteLine("Введите число");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int Line(int sum)
{
    if (sum == 0) return 0;
    else
    {
        sum = sum % 10 + Line(sum / 10);
    }
    return sum;
}
Console.WriteLine(Line(num));

