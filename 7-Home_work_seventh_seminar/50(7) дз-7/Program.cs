// Практическое задание №7
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.Clear();
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите колличество строк массива");
int n = ReadInt("Введите колличество столбцов массива");
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

Console.WriteLine();
int x = ReadInt("Введите координаты индекса строки");
int y = ReadInt("Введите координаты индекса столбца");
if (x > m || y > n || x < 0 || y < 0)
    Console.WriteLine("позиции элемента не верно указаны, такого элемента нет");
else
{
    Console.WriteLine(array[x-1, y-1]);
}
