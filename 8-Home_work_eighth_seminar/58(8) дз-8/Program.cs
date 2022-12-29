// Home work #8
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.Clear();
int ReadInt(string message)                                             // Метод внесения данных.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int k = ReadInt("Введите число строк 1-й матрицы: ");
int l = ReadInt("Введите число столбцов 1-й матрицы: ");
int m = ReadInt("Введите число строк 2-й матрицы: ");
int n = ReadInt("Введите число столбцов 2-й матрицы: ");

if (l != m)                                                            // Огранечение условиями после ввода данных для созж-я массивов.
{
    Console.WriteLine("Матрицы умножить невозможно! Число столбцов в первом сомножителе не равно числу строк во втором.");
    return;
}

int varriable = ReadInt("Введите диапазон случайных чисел из которых будут матрицы: от 1 до 10");

int[,] firstMatr = new int[k, l];
RandomArray(firstMatr);
Console.WriteLine("\n\t\t1-я матрица:");
PushArray(firstMatr);

int[,] secondMatr = new int[m, n];
RandomArray(secondMatr);
Console.WriteLine("\n\t\t2-я матрица:");
PushArray(secondMatr);

int[,] result = MatrixProduct(firstMatr, secondMatr);
Console.WriteLine("\n\t\tПроизведение матриц равно:");
PushArray(result);

void RandomArray(int[,] array)                                            // Метод создания массива со случайными элементами в диапазоне,
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(varriable);                   // заданной переменной.
        }
    }
}

void PushArray(int[,] array)                                              // Метод, вывода массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] firstMatr, int[,] secondMatr)                 // Произведение элементов массива.
{
    int[,] resultMatr = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatr.GetLength(1); j++)
        {

            resultMatr[i, j] += firstMatr[i, j] * secondMatr[i, j];

        }
    }
    return resultMatr;
}