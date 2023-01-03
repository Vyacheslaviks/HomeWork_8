/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

//тело программы

using MyMethods;

int[,] array_1 = Sl.GenerateRandomArrayInt(2,3,0,9);
int[,] array_2 = Sl.GenerateRandomArrayInt(3,4,0,9);

Sl.PrintArray(array_1);
Sl.PrintArray(array_2);

Sl.PrintArray(MultipleMatrix(array_1, array_2));

//методы

int[,] MultipleMatrix(int[,] array_1, int[,] array_2)
{
        if(array_1.GetLength(1) != array_2.GetLength(0))
    {
        throw new ArgumentException("Вы не можете перемножить матрицы c такими размерами.");
    }

    int[,] result_array = new int[array_1.GetLength(0), array_2.GetLength(1)];

    for(int i = 0; i < array_1.GetLength(0); i++)
    {
        for(int j = 0; j < array_2.GetLength(1); j++)
        {
            for(int k = 0; k < array_1.GetLength(1); k++)
            {
                result_array[i,j] = result_array[i,j] + array_1[i,k] * array_2[k,j];
            }
        }
    }

    return result_array;
}