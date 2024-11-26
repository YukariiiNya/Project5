using System;

class Program
{
    // Метод сортировки массива по возрастанию
    static void SortArrayAscending(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Массив отсортирован по возрастанию:");
        PrintArray(array);
    }

    // Метод сортировки массива по убыванию
    static void SortArrayDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine("Массив отсортирован по убыванию:");
        PrintArray(array);
    }

    // Метод объединения двух массивов в один
    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        array1.CopyTo(mergedArray, 0);
        array2.CopyTo(mergedArray, array1.Length);
        return mergedArray;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array1 = { 5, 3, 8, 1, 2 };
        int[] array2 = { 7, 6, 9 };

        // Демонстрация работы методов
        SortArrayAscending(array1);
        SortArrayDescending(array1);

        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединенный массив:");
        PrintArray(mergedArray);
    }
}
