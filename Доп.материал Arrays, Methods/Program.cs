Console.Clear();
// int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };



// int result = Int32.Parse(input);                                           // Преобразовать строку в Int.
// Console.WriteLine(result); 



// 4-й семинар в задачу на 18 строку int A = ReadInt("Введите число: ");

// Console.WriteLine(string.Join(", ", array)); 



//int ReadInt(string message)                                                 // Создали метод для вывода на экран.
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());                           // От пользователя ответ прочитали, сконвертировали и сразу  отдали.
// }



// int SumNumbers = Math.Abs(rez);                                          // Для преобразования отрицательных чисел в положительные.



// int ElementsDigit = int.Parse(Console.ReadLine());   // Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа.



// Console.Write("]");



// int[] GetRandomArray(int length, int leftRange, int rightRange)     // Метод создания случайного массива.
// {
//     int[] array = new int[length];                                  // Создаем массив из Length элементов
//     Random rand = new Random();                                     // Переменная класса Random.
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);            // Каждому элементу массива делаем присвоение случайного числа.
//     }                                                               // +1 для включения последнего числа, т.е. 9, т.к. изначально оно не входит

//     return array;
// }

// const int LENGTH = 5;
// const int LEFTRANGE = -9;
// const int RIGHTRANGE = 9;


// string centerText = "Center";                                        //Инициализируем переменные, содержащие строки вывода
// //Выводим строку в центре экрана
// int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
// int centerY = (Console.WindowHeight / 2) - 1;
// Console.SetCursorPosition(centerX, centerY);
// Console.Write(centerText);
 
// Console.ReadKey();                                                   //Ждём нажатия клавиши перед выходом



// int[,,] GetRandomMatrix(int[] length, int min, int max)              // Метод создания трехмерного массива.
// {
//     int[,,] result = new int[length[0], length[1], length[2]];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//                 int digit = new Random().Next(min, max + 1);
//                 if (FindElement(result, digit)) 
//                 {
//                     continue;
//                 }
//                 result[i, j, k] = digit;
//             }
//         }
//     }
//     return result;
// }



// Split создает массив подстрок, разбивая входную строку по одному или нескольким разделителям.
// Чтобы исключить из результирующего массива пустые подстроки, вызываем перегрузку и указываем StringSplitOptions.RemoveEmptyEntries.
// string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);