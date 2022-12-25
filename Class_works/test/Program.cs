Console.Clear();
// int ReadInt(string message)                         // Создали метод для вывода на экран и получения числа (c 7-11 строку)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());     // От пользователя ответ прочитали, сконвертировали и сразу  отдали
// }

// int A = ReadInt("Введите число: ");                // Используем созданный метод, внося только одну строку
// 53
// int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// int tmp = 0;
// int n = array.GetLength(1);
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     tmp = array[0, j];
//     array[0, j] = array[n - 1, j];
//     array[n - 1, j] = tmp;
// }

// for(int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]);
//     }
//     Console.WriteLine();
// }

// 55
// // Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Указать проверку на равенство строк и столбцов.
// int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


// int tmp = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++) // ToString после GetLength для работы со строками.
//     {
//         tmp = array[i, j];
//         array[i, j] = array[j, i];
//         array[j, i] = tmp;
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[j, i]);
//     }
//     Console.WriteLine();
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

// 59
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
// int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// 67
// Console.WriteLine("Введите число");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int Line(int sum)
// {
//     if (sum == 0) return 0;
//     else
//     {
//         sum = sum % 10 + Line(sum / 10);
//     }
//     return sum;
// }
// Console.WriteLine(Line(num));

// 69
// Console.WriteLine("Введите основание и степень");
// int osn = Convert.ToInt32(Console.ReadLine());
// int step = Convert.ToInt32(Console.ReadLine());
// int Stepen(int n, int m)
// {
//     if (m == 0) return 1;
//     n += Stepen(n, m - 1);
//     return n;
// }
// Console.WriteLine(Stepen(osn, step));

