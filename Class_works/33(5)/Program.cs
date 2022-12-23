// Практическое задание №5
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();
void FillArray(int[] array)                     // Метод создания случайного массива.
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(40, 50);
    }
}

void FindDigit(int[] array, int digit)
{
    bool find = false;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]==digit)
        {
            find=true;
        }
        // break; // При установке не видит числа.

    }
    if(find==true)
    Console.WriteLine("Да");
    else
    {
        Console.WriteLine("Нет");
    }
}
Console.WriteLine("Введите число для поиска: ");
int number=Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
FillArray(array);
Console.WriteLine($"{string.Join(", ", array)}");
FindDigit(array,number);