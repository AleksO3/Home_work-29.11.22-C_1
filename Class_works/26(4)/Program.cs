// Практическое задание №4
// Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 - 3
// 12 - 2
// 1234567 -7
Console.Clear();
int ReadInt(string message)                         // Создали метод для вывода на экран (c 7-11 строку)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());     // От пользователя ответ прочитали, сконвертировали и сразу  отдали
}

int number = ReadInt("Введите любое число: ");             // Используем и вызываем созданный метод, внося только одну строку

int getCountOfDigits(int number)                   // метод подсчета делений на 10, пока number !=0;
{
    if (number==0) return 1; 
    int count = 0;                                    // ввели переменную для счетчика
    while (number != 0)                               // выполняем действие пока number !=0;
    {
        number /= 10;                                 // делим на 10
        count++;                                    // счетчик увеличивается каждый раз
    }
    return count;                                   // выводим счетчик
}

// if (number == 0)                               // указали другой вариант подстановки условия, более длинный, но тоже рабочий с 26-34
// {
//     Console.WriteLine(1);
// }
// else
// {
int result = getCountOfDigits(number);
Console.WriteLine(result);
// }