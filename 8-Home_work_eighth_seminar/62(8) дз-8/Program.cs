// Home work #8
// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
Console.Clear();
int ReadInt(string message)                                             // Метод внесения данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int q = ReadInt("Введите размер массива, например: ");                 // Благодаря переменной задаем размер массива.
int[,] matrix = new int[q, q];
int i = 0;
int j = 0;
int step = 1;                                                          // Назначаем временную переменную.

void PushArray(int[,] array)                                           // Метод, вывода массива.
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

while (step <= matrix.GetLength(0) * matrix.GetLength(1))            // Делаем, пока врем-я переменная будет выполнять условия.
{
    matrix[i, j] = step;
    step++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PushArray(matrix);