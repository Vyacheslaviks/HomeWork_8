/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

//тело программы

using MyMethods;

int[,] array_1 = Sl.GenerateRandomArrayInt(2,3,0,9);
int[,] array_2 = Sl.GenerateRandomArrayInt(4,4,0,9);

Sl.PrintArray(array_1);
Sl.PrintArray(array_2);


//методы

void CheckMatrix(int[,] array_1, int[,] array_2)
{
    if(array_1.GetLength(1) != array_2.GetLength(0))
    {
        throw new ArgumentException("Вы не можете перемножить матрицы c такими размерами.");
    }
}