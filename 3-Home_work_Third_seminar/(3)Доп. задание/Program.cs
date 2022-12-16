// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив
Console.Clear();
// Console.WriteLine("Введите массив");
//array = Convert.ToInt32(Console.ReadLine());
int[] array = {0,2,3,5,5,4};
for (int i = array.Length - 1; i >=0; i--)
{
    Console.Write(array[i]);
}