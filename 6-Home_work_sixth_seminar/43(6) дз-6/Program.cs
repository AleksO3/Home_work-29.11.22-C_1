// Практическое задание №6
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
int ReadInt(string message)                         // Создали метод для вывода на экран и получения числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());     // От пользователя ответ прочитали, сконвертировали и сразу  отдали
}

double b1 = ReadInt("Введите число: ");
double k1 = ReadInt("Введите число: ");
double b2 = ReadInt("Введите число: ");
double k2 = ReadInt("Введите число: ");

if (k1 == k2)
{
    Console.WriteLine("Линии параллельны и в этом измерении не пересекуться");
}

else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;


    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}