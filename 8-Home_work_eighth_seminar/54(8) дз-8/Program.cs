//  Practice #8
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.Clear();
int ReadInt(string message)                                         // Метод внесения данных.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
int varriable = ReadInt("Введите диапазон случайных чисел из которых будет создана матрица: от 1 до 10");

void RandomArray(int[,] array)                                      // Метод создания массива со случайными элементами в диапазоне,
{                                                                   // заданной переменной.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(varriable);
        }
    }
}

void PushArray(int[,] array)                                        // Метод, вывода массива.
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

void UpArray(int[,] array)                                          // Метод для распределения элементов по возрастанию.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[m, n];
RandomArray(array);
PushArray(array);

Console.WriteLine("\n\t\tМассив с элементами по возрастанию: ");
UpArray(array);
PushArray(array);