/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int m = new Random().Next(1, 10);
Console.WriteLine($"Количество строк: {m}");
int n = new Random().Next(1, 10);
Console.WriteLine($"Количество столбцов: {n}");
int[,] array = new int[m, n];
Console.WriteLine("Исходный массив:");
FillArray(array, m, n);
PrintArray(array);
Console.WriteLine("Упорядоченный массив:");
SortArray(array);
PrintArray(array);

void FillArray(int[,] array, int m, int n)
{
    int[,] array1 = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    int min = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = min;
                }
        }
    }
}