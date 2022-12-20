// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// int[] array = {1,2,3,4,5};

// (array.Length + 1)/ 2
// array.Length  / 2 + array.Length % 2

Console.Clear();
int[] array = { 1, 2, 3, 4, 5 };

int[] array2 = new int[array.Length / 2 + array.Length % 2];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[array.Length - 1 - i];
    if (i == array.Length - 1 - i)
    {
        array2[i] = array[i];
    }
}

Console.WriteLine(string.Join(", ", array2));

//// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// if вынести за цикл

// int[] array = {1,2,3,4,5};

// int[] array2 = new int [array.Length  / 2 + array.Length % 2];

// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i]= array[i]*array[array.Length-1-i];
// }
// Console.WriteLine(string.Join(", " ,  array2));
