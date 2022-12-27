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

int rows = ReadInt("Введите колличество строк массива");
int columns = ReadInt("Введите колличество столбцов массива");

int[,] array = new int[rows, columns];
// double[,] a = new double[rows, columns];
double[] b = new double[columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        array[i, j] = i * j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0, k = 0; i < columns; i ++)
{
    double summa = 0;
    for (int j = 0; j < columns; j++)
    {
        summa += array[i, j];
    }
    b[k] = summa / rows;
    Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " равно: " + b[k]);
    k++;
}