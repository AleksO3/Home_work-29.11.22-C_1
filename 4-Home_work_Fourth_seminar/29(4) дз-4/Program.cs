// Практическая работа №4
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
Console.Clear();
Console.Write("Введите количество элементов массива, например 8 и кликните ENTER:  ");
                                                     // Переменная, в которую занесутся вводные значения.
int ElementsDigit = int.Parse(Console.ReadLine());   // Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа.
int[] MyArray = new int[ElementsDigit];              // Создали массив, в который и внесли переменную с количеством элементов.
                                                     
for (int i = 0; i < MyArray.Length; i++)             // Благодаря циклу полностью пройдемся по массиву.
{
    Console.Write($"Введите элемент массива под индексом {i} и кликните ENTER:  ");  // Каждую итерацию выводит на экран.
    MyArray[i] = int.Parse(Console.ReadLine());
}

Console.Write($"\n Ваш массив: ");
for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write(MyArray[i]);
}