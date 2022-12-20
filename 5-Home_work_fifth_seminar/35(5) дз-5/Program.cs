// Практическое задание №5
// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
const int MINBORDER = 0;
const int MAXBORDER = 150;
const int LENGTH = 123;

int[] Array(int size, int minR, int maxR)
  {
        int[] massiv = new int[size];
    Random rand = new Random();
    for (int i=0; i<massiv.Length; i++)
    { massiv[i]=rand.Next(minR,maxR+1); }
      return massiv;
   }
int CountNBorders(int[] massiv)
    {
  int count = 0;
  for (int i=0; i<massiv.Length; i++)
    {
    if (massiv[i]>=10 && massiv[i]<=99)
      count++;
    }
    return count;
  }

int[] ShowArray = Array(LENGTH, MINBORDER, MAXBORDER); 
Console.WriteLine($"[{string.Join(", ", ShowArray)}]");
int raznica = CountNBorders(ShowArray);
Console.WriteLine($"Количество элементов в диапазоне [10;99]: {raznica}");