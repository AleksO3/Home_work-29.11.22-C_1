// Практическое задание №5
// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
const int MINRANGE = 0;
 const int MAXRANGE = 150;
 const int SIZE = 123;
 
 int[] SuperMassive(int size, int minRange, int maxRange)
  {
   int[] massiv = new int[size];
   Random rand = new Random();
   for (int i=0; i<massiv.Length; i++)
   {massiv[i]=rand.Next(minRange,maxRange+1); }
      return massiv;
  }
 
 int CountNumbersRange(int[] massiv)
 {
  int count = 0;
  for (int i=0; i<massiv.Length; i++)
  {
   if (massiv[i]>=10 || massiv[i]<=99)
    count++;
  }
  return count;
 }
 
 int[] massiv = SuperMassive(MINRANGE, MAXRANGE, SIZE);
 Console.WriteLine($"[{string.Join(", ", massiv)}]");
 int rangeCount = CountNumbersRange(massiv);
 Console.WriteLine($"количество элементов диапазона 10-99: {rangeCount}");
