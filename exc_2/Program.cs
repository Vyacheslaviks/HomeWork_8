/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

//тело программы

using MyMethods;

int[,] array = Sl.GenerateRandomArrayInt(4, 4, 0, 9);
Sl.PrintArray(array);

Console.WriteLine($"Строка {SearchMinimalSumRows(array).Item1} имеет минимальную сумму элементов: {SearchMinimalSumRows(array).Item2}");

//методы

int SumInRows(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    return sum;
}

(int, int) SearchMinimalSumRows(int[,] array)
{
    int current = 0;
    int min = 0;
    int min_index = 0;

    int[] row_array = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row_array[j] = array[i, j];
        }
        
        current = SumInRows(row_array);

        if(i == 0)
        {
            min = current;
        }
        
        if (current < min)
        {
            min = current;
            min_index = i;
        }
    }

    return (min_index, min);
}