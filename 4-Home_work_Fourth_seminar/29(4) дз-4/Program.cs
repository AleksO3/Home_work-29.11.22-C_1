// Практическая работа №4
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
Console.Clear();

int GiveMeCount(string Numbers)
{
    Console.Write(Numbers);
    return Convert.ToInt32(Console.ReadLine());
}

for(int i=0;i<9;i++)
{
    int N1 = GiveMeCount("Введите число и нажмите ввод (ENTER): ");

}

int[] array = new int[8] {N1, };
Console.WriteLine(string.Join(", ", array)); 