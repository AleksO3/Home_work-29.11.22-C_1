// Практическое задание №5
// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
Console.Clear();

int[] GetRandomArray(int length, int leftRange, int rightRange)     // Метод создания случайного массива.
{
    int[] array = new int[length];                                  // Создаем массив из Length элементов
    Random rand = new Random();                                     // Переменная класса Random.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);            // Каждому элементу массива делаем присвоение случайного числа.
    }                                                               // +1 для включения последнего числа, т.е. 9, т.к. изначально оно не входит

    return array;
}



(int, int) SumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;                                            // Сумма положительных элементов.
    int sumNegative = 0;                                            // Сумма отрицательных элементов.

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)                                           // Если элемент положительный.
        {
            sumPositive += array[i];                                // Копить положительную сумму.
        }
        else                                                        // Иначе элемент отрицательный (или == 0).
        {
            sumNegative += array[i];                                // Копить отрицательную сумму.
        }
    }
    return (sumPositive, sumNegative);
}

const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int sumP, int sumN) = SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");