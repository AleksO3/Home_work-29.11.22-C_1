﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число или около того");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Concat($"{a}".Reverse()));
int result = Int32.Parse(a);
Console.WriteLine(result);