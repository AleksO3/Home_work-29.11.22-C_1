// Практическая работа №6
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Clear();
int[] array = { 11, 1, 2, 3 };
int[] copyArray = new int[array.Length];
for (int i= 0; i < array.Length; i++)
{
    copyArray[i]=array[i];
}
Console.WriteLine(string.Join(", ", copyArray));