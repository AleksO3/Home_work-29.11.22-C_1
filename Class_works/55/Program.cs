// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
Console.Clear();
//считывает целое число от пользователя
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
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
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}

int[,] TMatrix(int[,] sourceMatrix)
{
    int[,] tmatrix = new int[sourceMatrix.GetLength(1), sourceMatrix.GetLength(0)];

    for(int i = 0; i < tmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tmatrix.GetLength(1); j++)
        {
            tmatrix[i, j] = sourceMatrix[j, i];
        }
    }

    return tmatrix;
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
int[,] newMatrix = TMatrix(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);