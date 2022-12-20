// Практическое задание №5
// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------------------*/
int min = Int32.MaxValue;                                           // Представляет наименьшее возможное значение.
int max = Int32.MinValue;                                           // Представляет наибольшее возможное значение.
/*-------------------------------------------------------------------------------------------------------------------------------------*/
void randomDigits(int[] digits)
{
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] digits)
{
    for (int i = 0; i < digits.Length; i++)
    {
        Console.Write(digits[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Укажите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[length];

randomDigits(digits);
Console.Write("Получите свой массив: ");
PrintArray(digits);

for (int i = 0; i < digits.Length; i++)
{
    if (digits[i] > max)
    {
        max = digits[i];
    }
    if (digits[i] < min)
    {
        min = digits[i];
    }
}

Console.WriteLine($"Максимум = {max}, минимум = {min}");
Console.WriteLine($"Разница между числами = {max - min}");