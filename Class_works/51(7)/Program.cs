// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.Clear();

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 50);
        }
    }
    return matrix;
}
// Метод просчета суммы диагонали
int SumOfDiagonalue(int[,] matr)
{
    int sum = 0;
    int min = matr.GetLength(0);
    if (min > matr.GetLength(1))
    {
        min = matr.GetLength(1);
    }
    for (int i = 0; i < min; i++)
    {
        sum += matr[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = ReadInt("Введите число строк");
int columns = ReadInt("Введите число столбцов");
int[,] matrix = FillArray(rows, columns);
PrintMatrix(matrix);
int result = SumOfDiagonalue(matrix);
Console.WriteLine($"Сумма элементов по диагонали равна {result}");