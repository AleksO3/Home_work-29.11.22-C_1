// Практическое задание №7
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void RandomDigits(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int m = ReadInt("Введите колличество строк массива");
int n = ReadInt("Введите колличество столбцов массива");
int[,] array = new int[m, n];

int[,] digits = new int[m, n];
RandomDigits(digits);

for (int i = 0; i < digits.GetLength(1); i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < digits.GetLength(0); j++)
    {
        arithmeticMean = (arithmeticMean + digits[j, i]);
    }
    arithmeticMean = arithmeticMean / m;
    arithmeticMean = Math.Round(arithmeticMean, 1);
    Console.Write(arithmeticMean + "; ");
}
Console.WriteLine();
PrintArray(digits);