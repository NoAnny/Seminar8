/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int k = new Random().Next(1, 5);
Console.WriteLine($"Массив размерами {m} x {n} x {k}");

int[,,] array = new int[m, n, k];

FillArray(array, m, n, k);
PrintArray(array);

void FillArray(int[,,] array, int m, int n, int k)
{
    int[] new_array = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < new_array.GetLength(0); i++)
    {
        new_array[i] = new Random().Next(10, 100);
        number = new_array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (new_array[i] == new_array[j])
                {
                    new_array[i] = new Random().Next(10, 100);
                    j = 0;
                    number = new_array[i];
                }
                number = new_array[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = new_array[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}