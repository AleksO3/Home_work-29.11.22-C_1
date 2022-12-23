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