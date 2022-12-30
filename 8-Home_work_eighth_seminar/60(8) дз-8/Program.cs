// Home work #8
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.Clear();

bool FindDigits(int[,,] array, int element)                            // Метод типа bool, Ставим условие на правду-ложь(true-false).
{
    for (int i = 0; i < array.GetLength(0); i++)                       // Понадобится для метода GetRandomMatrix.
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}


int[,,] GetRandomMatrix(int[] length, int min, int max)                     // Метод создания трехмерного массива.
{
    int[,,] result = new int[length[0], length[1], length[2]];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                int digit = new Random().Next(min, max + 1);
                if (FindDigits(result, digit))                      
                {
                    continue;
                }
                result[i, j, k] = digit;
            }
        }
    }
    return result;
}


void PushArray(int[,,] array)                                           // Метод вывода массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine("\n");
        }
    }
}

Console.WriteLine("Размеры массива вводите через пробел:");

// Split создает массив подстрок, разбивая входную строку по одному или нескольким разделителям.
// Чтобы исключить из результирующего массива пустые подстроки, вызываем перегрузку и указываем StringSplitOptions.RemoveEmptyEntries.
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа.
int[,,] array = GetRandomMatrix(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]), }, 10, 99);
Console.Write("\n");
PushArray(array);