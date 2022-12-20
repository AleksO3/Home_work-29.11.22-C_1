// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.Clear();

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    double[,] matr = new double[rows, columns];

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

void PowEven(double[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for( int j=0;j<matrix.GetLength(1);j++)
        if(i%2==0&&j%2==0)
        {
            matrix[i,j]=Math.Pow(matrix[i,j],2);
        }
    }
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int rows=ReadInt("Введите число строк");
int columns=ReadInt("Введите число столбцов");
double[,] matrix=GetRandomMatrix(rows,columns);
PrintMatrix(matrix);
PowEven(matrix);
Console.WriteLine();
PrintMatrix(matrix);