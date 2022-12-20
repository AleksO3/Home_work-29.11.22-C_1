// Практика №7
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// Console.Clear();
// //считывает целое число от пользователя
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
// {
//     int[,] matr = new int[rows, columns];

//     var rand = new Random();
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//     }
// }


// int rowsCount = ReadInt("Введите число строк");
// int columnsCount = ReadInt("Введите число столбцов");
// int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
// PrintMatrix(matrix);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();
// //считывает целое число от пользователя
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 6)
// {
//     int[,] matr = new int[rows, columns];

//     // var rand = new Random();
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i+j; //rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//     }
// }
// int rowsCount = ReadInt("Введите число строк");
// int columnsCount = ReadInt("Введите число столбцов");
// int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
// PrintMatrix(matrix);




// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
// {
//     double[,] matr = new double[rows, columns];

//     var rand = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }
//     return matr;
// }

// void PowEven(double[,] matrix)
// {
//     for(int i=0;i<matrix.GetLength(0);i++)
//     {
//         for( int j=0;j<matrix.GetLength(1);j++)
//         if(i%2==0&&j%2==0)
//         {
//             matrix[i,j]=Math.Pow(matrix[i,j],2);
//         }
//     }
// }

// void PrintMatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// int rows=ReadInt("Введите число строк");
// int columns=ReadInt("Введите число столбцов");
// double[,] matrix=GetRandomMatrix(rows,columns);
// PrintMatrix(matrix);
// PowEven(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int ReadInt(string message)
// {
//     Console.Write(message + " ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] FillArray(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     var rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(1, 50);
//         }
//     }
//     return matrix;
// }
// // Метод просчета суммы диагонали
// int SumOfDiagonalue(int[,] matr)
// {
//     int sum = 0;
//     int min = matr.GetLength(0);
//     if (min > matr.GetLength(1))
//     {
//         min = matr.GetLength(1);
//     }
//     for (int i = 0; i < min; i++)
//     {
//         sum += matr[i, i];
//     }
//     return sum;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите число строк");
// int columns = ReadInt("Введите число столбцов");
// int[,] matrix = FillArray(rows, columns);
// PrintMatrix(matrix);
// int result = SumOfDiagonalue(matrix);
// Console.WriteLine($"Сумма элементов по диагонали равна {result}");