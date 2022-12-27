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


// double[,] a = new double[5, 5];
int[] b = new int[rows];

int[,] GetRandomMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
    }
}
//инициализация a
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         array[i, j] = i * j + 1;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
int matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);

for (int i = 0, k = 0; i < rows; i ++)
{
    int summa = 0;
    for (int j = 0; j < rows; j++)
    {
        summa += array[i, j];
    }
    b[k] = summa / rows;
    Console.WriteLine("Nср столбца " + (i + 1) + " равно: " + b[k]);
    k++;
}