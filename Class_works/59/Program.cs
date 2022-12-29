// Семинар №8
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
Console.Clear();
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 9)
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

int[,] DeleteMinElement(int[,] sourceMatrix)
{
    int min = sourceMatrix[0, 0];
    int mini = 0;
    int minj = 0;

    for (int i = 0; i < sourceMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sourceMatrix.GetLength(1); j++)
        {
            if (sourceMatrix[i, j] < min)
            {
                mini = i;
                minj = j;
                min = sourceMatrix[i, j];
            }
        }
    }

    int[,] newMatrix = new int[sourceMatrix.GetLength(0) - 1, sourceMatrix.GetLength(1) - 1];
    int rowOffset = 0;
    int columnOffset = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == mini) rowOffset = 1;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minj) columnOffset = 1;
            newMatrix[i, j] = sourceMatrix[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    Console.WriteLine($"Наименьший элемент - {min}, на выходе получим следующий массив:");

    return newMatrix;
    Console.WriteLine();
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
int[,] result = DeleteMinElement(matrix);
PrintMatrix(result);
