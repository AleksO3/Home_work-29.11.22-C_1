// Практическая работа №4
// Задача 28. Принимает число N и выводит произведение от 1 до N
// 4 - 24
// 5 - 120
Console.Clear();
int ReadInt(string message)                         // Создали метод для вывода на экран (c 7-11 строку)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());     // От пользователя ответ прочитали, сконвертировали и сразу  отдали
}

int GetProductToNumber(int number)                  // Метод, который возвращает произведение чисел от 1 до number
{
    int product = 1;
    for(int i=1; i<= number;i++)
    {
        product *= i;//product=product*i;
    }
    return product;
}

int A = ReadInt("Введите число: ");             // Используем созданный метод, внося только одну строку
int result = GetProductToNumber(A);
Console.WriteLine($"Произведение чисел от 1-го до {A} = {result}");