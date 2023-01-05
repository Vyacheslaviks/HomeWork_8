/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

//тело программы

using MyMethods;

int[,] array = Sl.GenerateRandomArrayInt(3, 5, 0, 9);
Sl.PrintArray(array);

//выделяю из исходного массива строки и засылаю их в функцию
int[] row_array = new int[array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        row_array[j] = array[i, j];
    }
    Sl.PrintArray(MyBubbleSort(row_array));
    Console.WriteLine();
}

//методы

int[] MyBubbleSort(int[] local_array)
{
    int temp = 0;
    int count = 0;

    while (count != local_array.Length-1)
    {
        for (int i = 1; i < local_array.Length; i++)
        {
            if (local_array[i - 1] < local_array[i])
            {
                temp = local_array[i];
                local_array[i] = local_array[i - 1];
                local_array[i - 1] = temp;
            }
        }
        count++;
    }

    return local_array;
}