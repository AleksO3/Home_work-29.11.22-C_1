// Практическое задание №7
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetRandomMatrix(int rows, int columns, int leftRange = -100, int rightRange = 100)
{
    double[,] matr = new double[rows, columns];

    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)                                                 // Строки с 0.
    {
        for (int j = 0; j < matr.GetLength(1); j++)                                             // Столбцы с 1.
        {
            matr[i, j] = (rand.Next(leftRange, rightRange + 1) / 10.0);
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

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
double[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);