// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.Clear();
int ReadInt(string message)                                      // Метод внесения данных.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
int varriable = ReadInt("Введите диапазон случайных чисел из которых будет создана матрица: от 1 до 10");

void RandomArray(int[,] array)                                  // Метод создания массива со случайными элементами в диапазоне,
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(varriable);         // заданной переменной.
        }
    }
}

void PushArray(int[,] array)                                    // Метод, вывода массива.
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

int sumStringDigits(int[,] array, int i)                       // Метод определения наименьшей суммы в строке массива.
{
    int sumString = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumString += array[i, j];
    }
    return sumString;
}

int[,] array = new int[m, n];
RandomArray(array);
PushArray(array);

int minSum = 0;                                              // Определяем сумму в строках и находим наименьшую.
int sumString = sumStringDigits(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = sumStringDigits(array, i);
    if (sumString > tempSumLine)
    {
        sumString = tempSumLine;
        minSum = i;
    }
}

Console.WriteLine($"\n\t\tНаименьшая сумма элементов в строке под номером {minSum + 1} равная {sumString}");
Console.WriteLine("");