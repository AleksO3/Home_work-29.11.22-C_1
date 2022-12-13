// Практическое задание №4
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
int ReadInt(string message)                         // Создали метод для вывода на экран (c 7-11 строку)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumToNumber(int number)                  // Метод, который возвращает сумму от 1 до number
{
    int sum = 0;
    for(int i=1; i<= number;i++)
    {
        sum += i;//sum=sum+i;
    }
    return sum;
}

int A = ReadInt("Введите число: ");             // Используем созданный метод, внося только одну строку
int result = GetSumToNumber(A);
Console.WriteLine($"Суииа чисел от 1-го до {A} = {result}");