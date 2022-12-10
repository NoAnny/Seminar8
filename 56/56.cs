/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int m = new Random().Next(1, 10);
Console.WriteLine($"Количество строк: {m}");
int n = new Random().Next(1, 10);
Console.WriteLine($"Количество столбцов: {n}");
int[,] array = new int[m, n];
Console.WriteLine("Полученный массив:");
FillArray(array, m, n);
PrintArray(array);
MinSumElRows(array);

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

void MinSumElRows(int[,] array)
{
    int min = 0; int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        if (i > 0 && summ < min)
        {
            min = summ;
            str = i;
        }
        if (i == 0)
        {
            min = summ;
            str = i;
        }
    }
    Console.WriteLine($"№ строки с наименьшей суммой элементов ({min}): {str + 1} ");
}
    