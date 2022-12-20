// Практическое задание №5
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] RandomArray(int length)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 10);
    }
    return array;
}

int SumNechet(int[] array)
{
    int Sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        Sum=Sum+array[i];
    }
    return Sum;
}

const int LENGTH = 4;

int[] arr = RandomArray(LENGTH);
System.Console.WriteLine(string.Join(", ", arr));
int sum = SumNechet(arr);
System.Console.WriteLine($"Сумма нечетных элементов равна {sum}");