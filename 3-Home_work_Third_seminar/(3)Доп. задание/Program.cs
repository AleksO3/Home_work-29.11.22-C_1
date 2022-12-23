// Доп. задание #39
// Написать метод для разворота массива, не используя память под дополнительный массив
Console.Clear();
// Console.WriteLine("Введите массив");
//array = Convert.ToInt32(Console.ReadLine());
// int[] array = {0,1,2,3,4,5};
// for (int i = array.Length - 1; i >=0; i--)
// {
//     Console.Write(array[i]);
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Другой вариант решения, наиболее оптимальный!

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

const int LENGTH = 5;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

void Reverse(int[] array)                                          // Метод для разворота массива.
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];                                        // Временная переменная.
        array[i] = array[array.Length - i - 1];                     // В значение слева записываем значение справа.
        array[array.Length - i - 1] = temp;                         // В значение справа записываем то, что сохранили во временную переменную.
    }
}

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
Console.WriteLine("");
Reverse(massive);
Console.WriteLine($"[{string.Join(", ", massive)}]");
