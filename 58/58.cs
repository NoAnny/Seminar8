/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int m = new Random().Next(1, 10);
Console.WriteLine($"Количество строк: {m}");
int n = new Random().Next(1, 10);
Console.WriteLine($"Количество столбцов: {n}");
int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
Console.WriteLine("1-я матрица:");
FillArray(array1, m, n);
PrintArray(array1);
Console.WriteLine("2-я матрица:");
FillArray(array2, m, n);
PrintArray(array2);
Console.WriteLine("Результирующая матрица:");
PrintArray(MultipleArrays(array1, array2));


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

int[,] MultipleArrays(int[,] array1, int[,] array2)
{
    int[,] multiple = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            multiple[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return multiple;
}