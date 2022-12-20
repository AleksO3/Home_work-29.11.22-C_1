// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();

int[] RandomArray(int length, int Lrange, int Rrange)                             // Метод создания случайного массива.
{
    int[] randomArr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < randomArr.Length; i++)
    {
        randomArr[i] = rand.Next(Lrange, Rrange + 1);
    }
    return randomArr;
}

const int SIZE = 4;
const int LRANGE = -100;
const int RRANGE = 100;

int[] Revers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < SIZE; i++)
    {
        count = arr[i];
        arr[i] = count * -1;
    }
    return arr;
}

int[] array = RandomArray(SIZE, LRANGE, RRANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
int[] reversArray = Revers(array);
Console.WriteLine($"[{string.Join(", ", reversArray)}]");