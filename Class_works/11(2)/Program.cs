// Практическое заданме №2
// Задача 11 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Clear();
int N = new Random().Next(100, 1000);
Console.WriteLine(N);
int first = N / 100;
int last = N % 10;
Console.WriteLine($"{first} {last}");